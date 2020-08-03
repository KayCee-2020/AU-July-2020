package com.company;


import java.util.Scanner;
import java.util.ArrayList;
import java.util.List;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;

class BlockingQueue{

    private List<Integer> list = new ArrayList<>();
    private int item = 0;
    private int max = 5;
    private int min = 0;

    public synchronized void put() {
        while(true) {
            if(list.size() == max) {
                System.out.println("Queue is full. No task is taken by any of the consumer.");
                try {
                    wait();
                } catch(InterruptedException e) {
                    e.printStackTrace();
                }
            }
            else {
                System.out.println(Thread.currentThread().getName() + " produced " + item);
                list.add(item++);
                notifyAll();
            }
        }
    }

    public synchronized void take() {
        while(true) {
            if(list.size() == min) {
                System.out.println("Queue is empty. There is no task present in the Queue.");
                try {
                    wait();
                } catch(InterruptedException e) {
                    e.printStackTrace();
                }
            }
            else {
                System.out.println(Thread.currentThread().getName() + " consumed " + list.remove(--item));
                notify();
            }
        }
    }
}

public class Main {

    public static void main(String[] args) throws InterruptedException {
        System.out.println("Enter the number of consumer threads to be created: ");
        Scanner myObj = new Scanner(System.in);
        int n = myObj.nextInt();

        BlockingQueue bq = new BlockingQueue();
        Thread producer = new Thread(()->bq.put());
        producer.start();

        ExecutorService consumer = Executors.newFixedThreadPool(n);
        for (int i = 0; i < n; i++) {
            consumer.submit(new Runnable() {
                public void run() {
                    bq.take();
                }
            });
        }
    }
}














