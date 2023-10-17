import 'dart:js_util';
import 'package:flutter/material.dart';
import 'package:login/pages/dash_geral_page.dart';
import '../model/usuario.dart';

class LoginPage extends StatefulWidget {
  const LoginPage({super.key});

  @override
  State<LoginPage> createState() => _LoginPageState();
}

class _LoginPageState extends State<LoginPage> {
  final campoNome = TextEditingController(),
      campoSenha = TextEditingController();
  GlobalKey<FormState> _formKey = new GlobalKey<FormState>();

  List<Usuario> _listaUsuario = [
    Usuario(senha: '1234', nome: "Tecnobar"),
  ];

  Widget _body() {
    return Padding(
      padding: EdgeInsets.only(
        top: 180,
        right: 8,
        left: 8,
        bottom: 8,
      ),
      child: ListView(
        children: [
          Container(
              alignment: Alignment.center,
              padding: EdgeInsets.all(10),
              child: Text(
                'Tecnobar',
                style: TextStyle(
                  color: Colors.blue.shade900,
                  fontWeight: FontWeight.w500,
                  fontSize: 30,
                ),
              )),
          Container(
            alignment: Alignment.center,
            padding: EdgeInsets.all(10),
            child: Text(
              'Entrar',
              style: TextStyle(fontSize: 20),
            ),
          ),
          Form(
            key: this._formKey,
            child: Column(
              children: [
                Container(
                  padding: EdgeInsets.all(10),
                  child: TextFormField(
                    controller: campoNome,
                    decoration: InputDecoration(
                      border: OutlineInputBorder(),
                      labelText: 'Nome de usuário',
                      filled: true,
                      fillColor: Colors.blue.shade200,
                    ),
                    validator: (value) {
                      if (value!.isEmpty) {
                        return "O Código não pode ser vazio";
                      } else {
                        if (campoNome.text.length < 3) {
                          return "O nome deve ter mais que 3 digitos";
                        }
                      }
                      return null;
                    },
                  ),
                ),
                Container(
                  padding: EdgeInsets.fromLTRB(10, 10, 10, 0),
                  child: TextFormField(
                    obscureText: true,
                    controller: campoSenha,
                    decoration: InputDecoration(
                      border: OutlineInputBorder(),
                      labelText: 'Senha',
                      filled: true,
                      fillColor: Colors.blue.shade200,
                    ),
                    validator: (value) {
                      if (value!.isEmpty) {
                        return "O Código não pode ser vazio";
                      } else {
                        if (campoNome.text.length < 3) {
                          return "O nome deve ter mais que 3 digitos";
                        }
                      }
                      return null;
                    },
                  ),
                ),
                TextButton(
                  onPressed: () {},
                  child: Text('Esqueci a senha'),
                ),
                Container(
                  padding: EdgeInsets.fromLTRB(10, 10, 10, 0),
                  child: ElevatedButton(
                      child: Text('Login'),
                      onPressed: () {
                        if (_formKey.currentState!.validate()) {
                          verificaLogin();
                          Navigator.push(context,
                              MaterialPageRoute(builder: (context) {
                            return DashboardPage();
                          }));
                        }
                      }),
                ),
                Row(
                  children: [
                    Text(
                      'Não possui conta?',
                    ),
                    TextButton(
                      child: Text(
                        'Cadastre-se',
                        style: TextStyle(fontSize: 20),
                      ),
                      onPressed: () {},
                    ),
                  ],
                  mainAxisAlignment: MainAxisAlignment.center,
                ),
              ],
            ),
          ),
        ],
      ),
    );
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Login Teste'),
        centerTitle: true,
      ),
      body: _body(),
    );
  }

  void verificaLogin() {
    String nome = campoNome.text;
    String senha = campoSenha.text;
    bool verifica = false;

    for (var usuario in _listaUsuario) {
      if (equal(nome, usuario.nome) && equal(senha, usuario.senha)) {
        verifica = true;
        break;
      }
    }
    if (verifica) {
      mostraMsgSucesso();
    } else {
      _showMyDialog();
    }
  }

  void mostraMsgSucesso() {
    ScaffoldMessenger.of(context)
        .showSnackBar(SnackBar(content: Text('Login feito com sucesso')));
  }

  Future<void> _showMyDialog() async {
    return showDialog<void>(
      context: context,
      barrierDismissible: false, // user must tap button!
      builder: (BuildContext context) {
        return AlertDialog(
          title: const Text('Login recusado!'),
          content: const SingleChildScrollView(
            child: ListBody(
              children: <Widget>[
                Text('Cadastre-se ou tente novamente.'),
              ],
            ),
          ),
          actions: <Widget>[
            ElevatedButton.icon(
              icon: Icon(Icons.exit_to_app),
              label: Text("Fechar"),
              onPressed: () {
                Navigator.of(context).pop();
              },
            ),
          ],
        );
      },
    );
  }
}
