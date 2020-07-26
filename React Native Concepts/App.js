import React from "react";
import { createStackNavigator } from '@react-navigation/stack';
import { NavigationContainer } from '@react-navigation/native';

import WorkList from "./src/components/WorkList"
import Login from "./src/components/Login"
import Dashboard from "./src/components/Dashboard";

const Stack = createStackNavigator();

function App() {
  return (
    <NavigationContainer>
      <Stack.Navigator>
        <Stack.Screen name="Login" component={Login} />
        <Stack.Screen name="Dashboard" component={Dashboard} />
        <Stack.Screen name="WorkList" component={WorkList} />
      </Stack.Navigator>
    </NavigationContainer>
  );
}

export default App;