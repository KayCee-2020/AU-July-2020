/******************************************************************************

                        interface telephone_model 
			telephone implenents the interface and provide three 			                        functionalities:
			1. making a call
			2. terminating a call
			3. redialling the last call
			4. showing dialled call history

*******************************************************************************/
import java.util.*;
import java.io.*; 

interface telephone_model{
    void make_call(String s); // Making a call by taking input of 10 digit number
    void terminate_call(); //Ending the call
    void redial(); // Redialling the last number dialled
    void receive_call(String r); // Recieving a call
    void call_log(); // Shows dial call history of user
}

class telephone implements telephone_model{
    
    public boolean on_call;
    public  Stack<String> stack = new Stack<String>(); 
    
    telephone(){
        on_call= false;
        stack.push("no calls made yet");
        
    }

    @Override
    public void make_call(String s)
    {
        String str;
        if(!on_call)
        {
            if(s.matches(" "))
            {
                System.out.println("Dial the number");
                int count=1;
                for(int i=1;i<=3;i++)
                {
                        for(int j=1;j<=3;j++)
                        {
                            System.out.print(count+++" | ");
                        }
                        System.out.println("\n");
                 }
                Scanner sc= new Scanner(System.in);   
                System.out.print("enter 10 digit number: ");  
                str= sc.nextLine();
            }
            else{ str=s; }
            System.out.println("Calling: "+str+"...");
            stack.push(str);
            terminate_call();
            
        }
        else 
        {
            System.out.println("Already on call");
        }
        
    }

    @Override    
    public void terminate_call()
    {
    //   Instant start = Instant.now();
            System.out.println("Press E to end the call");
            Scanner sc= new Scanner(System.in);   
            String str= sc.nextLine();
            if(str.regionMatches(true,0,"E",0,1))
            {
                // Instant end = Instant.now();
                // Duration timeElapsed = Duration.between(start, end);  
                System.out.println("call terminated...");
                on_call = false;
            }
    }

    @Override    
    public void redial()
    {
        if(!on_call)
        {
           String s = stack.peek(); 
           System.out.println("Redialling the last number in your list : "+s);
           make_call(s);
        }
    }

    @Override
    public void receive_call(String r)
    {
	    on_call = true;
        System.out.println(r+" is calling you");
        System.out.println("Press R to not take this call : Press Reject");
        Scanner sc= new Scanner(System.in);   
        String str= sc.nextLine();
        if(str.matches("R"))
        {
	    System.out.println("call rejected from "+r);
        }
        else
        {
            System.out.println("Talking to "+r+" .....");
            terminate_call();
        }
    }  
    
    @Override
    public void call_log()
    {
        System.out.println("the call history is :"+stack);
    }
     
    
    
}
public class Main{
	public static void main(String[] args) {
	    telephone obj = new telephone();
	    obj.make_call(" ");
	    obj.make_call(" ");
	    obj.redial();
	    obj.receive_call("8930295511");
	    obj.call_log();
	}
}
