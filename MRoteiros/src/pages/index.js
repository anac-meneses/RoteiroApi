import React, { Component } from "react";
import { View, Text, StyleSheet } from 'react-native';

class Destino extends Component {
    render() {
        return (
            <View style={styles.tabela}>
                <Text>ID: {this.props.data.id}</Text>
                <Text>Pais: {this.props.data.pais}</Text>
                <Text>Cidade: {this.props.data.cidade}</Text>
            </View>
        )
    }
}

export default Destino;

const styles = StyleSheet.create({
    tabela: {
        backgroundColor: '#FFE4E1',
        borderRadius: 20,
        padding: 20,
        fontSize: 14,
        margin: 10,
    },
  });
  