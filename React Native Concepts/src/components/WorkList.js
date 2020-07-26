import React, { useState, useEffect } from "react";
import { Text, TextInput, View, StyleSheet, Button, AsyncStorage, ImageBackground, TouchableOpacity,Alert } from "react-native";
import { add } from "react-native-reanimated";
import ShowList from './ShowList';



const WorkList= ({navigation}) =>{
    const [todoList, settodoList] = useState("");
    const [display,setDisplay] = useState("");
  
    useEffect(() => {
        checkTodo()
    }, [])

    const checkTodo = async () => {
        const list = await AsyncStorage.getItem("todoList");
        if (list) {
            setDisplay(list);
        }
        
    }
   

        const createTwoButtonAlert = () =>
        Alert.alert(
            'Alert Title',
            'My Alert Msg',
            [
              {
                text: 'Ask me later',
                onPress: () => console.log('Ask me later pressed')
              },
              {
                text: 'Cancel',
                onPress: () => console.log('Cancel Pressed'),
                style: 'cancel'
              },
              { text: 'OK', onPress: () => console.log('OK Pressed') }
            ],
            { cancelable: false }
          );

        // const createTwoButtonAlert1 = () =>
        //     Alert.alert(
        //     "Deleted Todo",
           
        //     [
        //         {
        //         text: "Cancel",
        //         onPress: () => console.log("Cancel Pressed"),
        //         style: "cancel"
        //         },
        //         { text: "OK", onPress: () => console.log("OK Pressed") }
        //     ],
        //     { cancelable: false }
        // );
    const addTodo = async () => {
        
        
       //await AsyncStorage.clear();
        try {
            const myArray = await AsyncStorage.getItem('todoList');
            console.log(myArray);
            if (myArray == null) {
             
              var obj = [];
              obj.push(todoList);
              await AsyncStorage.setItem('todoList', JSON.stringify(obj));
              await useEffect(() => {
                checkTodo()
              }, [])
             
            }
            else{
                var arr = JSON.parse(myArray);
                
               arr.push(todoList);
                await AsyncStorage.setItem('todoList', JSON.stringify(arr));
                await useEffect(() => {
                    checkTodo()
                  }, [])
                
                  
            }
          } catch (error) {
          }
        }
          
          const deleteTodo = async () => {
            console.log("hello");
        
             try {
                 const myArray = await AsyncStorage.getItem('todoList');
                 var newArr = await JSON.parse(myArray);
                 console.log(newArr);

                 var index = await newArr.indexOf(todoList);
                 if(index == -1){
                     return;
                 }
                 await newArr.splice(index, 1);
                 await AsyncStorage.setItem('todoList', JSON.stringify(newArr));
                 await useEffect(() => {
                    checkTodo()
                  }, [])
                 
               } catch (error) {
                 
                 console.log(error);
               }
            }
               


    
    return (
        <View>
            
            <TextInput style={Styles.textInputStyle} onChangeText={(todo) => settodoList(todo)} placeholder="Enter todolist..." />
            <Button title="Set Todo" onPress={
                () => { addTodo(); createTwoButtonAlert(); }
                }/>
            <Text>{display}</Text>
            <Text>Reload to see changes in todos</Text>
            <TextInput style={Styles.textInputStyle} onChangeText={(todo) => settodoList(todo)} placeholder="Enter todo to delete." />
            <Button title="Delete Todo" onPress={
                () => { deleteTodo(); createTwoButtonAlert();}
                } /> 
           
        </View>
       

    )  



    
}

const Styles = StyleSheet.create({
    title: {
        fontSize: 16,
        color: "white",
        fontWeight: "700",
        padding: 5
    },
    source: {
        fontSize: 16,
        color: "white",
        fontWeight: "700",
        padding: 5,
        alignSelf: "flex-end"
    },
    background: {
        width: "100%",
        height: "100%",
        justifyContent: "space-between"
    },
    container: {
        width: "95%",
        height: 150,
        marginLeft: "2.5%",
        marginRight: "2.5%",
        marginVertical: 5
    },
    textInputStyle: {
        borderColor: "black",
        borderWidth: 1,
        borderRadius: 5,
        fontSize: 20,
        padding: 5,
        width: "60%",
        marginBottom: 20
    }

})

export default WorkList;