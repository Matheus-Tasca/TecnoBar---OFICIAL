import 'package:login/model/usuario.dart';

class UsuarioRepository {
//atributo
  List<Usuario> _listaUsuario = [  ];

//construtor
  UsuarioRepository() {
    this._listaUsuario = [];
  }
 
  //adicionar Usuarios à lista
  void adicionar(Usuario usuario) {
    _listaUsuario.add(usuario);
  }
 
  //imprimir dados
  void imprimir() {
    for(var i = 0; i < _listaUsuario.length; i++) {
      print("Código: ${_listaUsuario[i].senha}, Nome: ${_listaUsuario[i].nome}");
    }
  }
}