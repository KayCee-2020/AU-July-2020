import React, { useState, useEffect } from "react";
import { Text, TextInput, View, StyleSheet, Button, AsyncStorage } from "react-native";

const Login = ({ navigation }) => {
    const [username, setUserName] = useState("");
    const [password, setPassword] = useState("");

    useEffect(() => {
        checkAuth()
    }, [])

    const checkAuth = async () => {
        const userName = await AsyncStorage.getItem("username");
        if (userName && password) {
            navigation.navigate("Dashboard");
        }
        return;
    }

    const login = async () => {
        await AsyncStorage.setItem("username", username);
        await AsyncStorage.setItem("password",password);
        navigation.navigate("Dashboard");
    }

    return (
        <View style={Styles.container}>
            <Text style={Styles.loginTextStyle}>Login</Text>
            <TextInput style={Styles.textInputStyle} onChangeText={(text) => setUserName(text)} placeholder="Please enter your username..." />
            <TextInput style={Styles.textInputStyle} onChangeText={(text) => setPassword(text)} placeholder="Please enter your password..." />
            <Button title="Log me in" onPress={login} />
        </View>
    )
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

export default Login;