import React, { Component }  from 'react';
import { FlatList, StyleSheet, View, Text, SafeAreaView } from 'react-native';
import api from './src/services/api';
import Destino from './src/pages';

class App extends Component{
  constructor(props){
    super(props);

    this.state = {
      destino:[]
    }
  }

  async componentDidMount(){
    const response = await api.get('api/Destino');
    this.setState({
      destino: response.data,
    });
  }

  render(){
    return(
      <SafeAreaView>
      <View style={styles.container}>
        <Text style={styles.titulo}>Lista de Destinos</Text>
        <FlatList 
        data={this.state.destino}
        keyExtractor={item => item.id.toString()}
        renderItem={({item}) => <Destino data={item} />}
        />
      </View>
      </SafeAreaView>
    )
  }
}
export default App; 

const styles = StyleSheet.create({
  container: {
   
    backgroundColor: '#E0FFFF',
    alignItems: 'center',
    justifyContent: 'center',
  },
  titulo: {
   
    fontSize: 26,
    },
});
