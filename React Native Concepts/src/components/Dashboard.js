import React from 'react';
import { StyleSheet, Text, View, Platform } from 'react-native';
import WorkList from './WorkList';
export default function Dashboard() {
  return (
    <View style={styles.container}>
      <Text>Welcome! wishing you a productive day.</Text>
      <WorkList></WorkList>
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    marginTop: Platform.OS=='android' ? 40 : 0,
    backgroundColor: '#fff',
    alignItems: 'center',
    justifyContent: 'center',
  },
});
