import React from 'react';
import { StyleSheet, Text, View, TextInput,TouchableOpacity, Button } from 'react-native';

const WorkList = (props)=>{
    // const [task_list, addTask] = useState([]);
    // const [task,setTask] = useState("");

    return(
        <TouchableOpacity style={styles.container}>
            <Text>Enter here</Text>
             <TextInput placeholder="enter your task here" /><Button >Add</Button>
        <View>
        </View>
        </TouchableOpacity>
    );
} 


const styles = StyleSheet.create({
    container: {
      backgroundColor: '#fff',
      alignItems: 'center',
      justifyContent: 'center',
    },
  });
export default WorkList;