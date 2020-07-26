import { createStackNavigator } from '@react-navigation/stack';
import { NavigationContainer } from '@react-navigation/native';
import React from 'react';
import Login from './src/components/Login';
import WorkList from './src/components/WorkList';
import { StyleSheet, Text, View } from 'react-native';


const Stack = createStackNavigator();

export default function App() {
  return (

    <NavigationContainer>
     
      <Stack.Navigator>
        <Stack.Screen name="Login" component={Login} />
        <Stack.Screen name="WorkList" component={WorkList} />
        
        
      </Stack.Navigator>
    </NavigationContainer>
   
  
  );
}

const Styles = StyleSheet.create({
    container: {
        flex: 1,
        justifyContent: "center",
        alignItems: "center"
    },
    loginTextStyle: {
        fontSize: 25,
        fontWeight: "700",
        marginVertical: 20
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
