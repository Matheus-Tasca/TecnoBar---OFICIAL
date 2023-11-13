// ignore_for_file: prefer_const_constructors, prefer_const_literals_to_create_immutables

import 'package:flutter/material.dart';

class HomePage extends StatefulWidget {
  const HomePage({Key? key}) : super(key: key);

  @override
  State<HomePage> createState() => _HomePageState();
}

class _HomePageState extends State<HomePage> {
  String _filtro = '30dias';
  double _cardValue = 5000;
  Color _cor = Colors.blueGrey;

  void _atualizaCards(String filter) {
    if (filter == '1dia') {
      _cardValue = 1000;
    } else if (filter == '7dias') {
      _cardValue = 7000;
    } else if (filter == '30dias') {
      _cardValue = 30000;
    } else if (filter == '3meses') {
      _cardValue = 90000;
    } else if (filter == '6meses') {
      _cardValue = 180000;
    } else if (filter == '1ano') {
      _cardValue = 360000;
    }
  }

  Widget _body() {
    return Padding(
      padding: EdgeInsets.all(8),
      child: ListView(
        children: [
          Container(
            alignment: Alignment.center,
            child: Text("Dados dos últimos:"),
          ),
          Container(
            alignment: Alignment.center,
            padding: EdgeInsets.all(8),
            child: DropdownButton<String>(
              value: _filtro,
              items: [
                DropdownMenuItem<String>(
                  value: '1dia',
                  child: Text('1 dia'),
                ),
                DropdownMenuItem<String>(
                  value: '7dias',
                  child: Text('7 dias'),
                ),
                DropdownMenuItem<String>(
                  value: '30dias',
                  child: Text('30 dias'),
                ),
                DropdownMenuItem<String>(
                  value: '3meses',
                  child: Text('3 meses'),
                ),
                DropdownMenuItem<String>(
                  value: '6meses',
                  child: Text('6 meses'),
                ),
                DropdownMenuItem<String>(
                  value: '1ano',
                  child: Text('1 ano'),
                ),
              ],
              onChanged: (String? newValue) {
                setState(() {
                  _filtro = newValue ?? '30dias';
                  _atualizaCards(_filtro);
                });
              },
            ),
          ),
          SizedBox(
            height: 15,
          ),
          Container(
            alignment: Alignment.center,
            padding: EdgeInsets.all(8),
            child: Card(
              color: _cor,
              elevation: 5,
              shape: RoundedRectangleBorder(
                borderRadius: BorderRadius.circular(10),
              ),
              child: SizedBox(
                width: 400,
                height: 100,
                child: Column(
                  children: [
                    Container(
                      padding: EdgeInsets.only(top: 10),
                      child: Text(
                        "Lucro",
                        style: TextStyle(fontSize: 18, fontWeight: FontWeight.bold),
                      ),
                    ),
                    Container(
                      padding: EdgeInsets.only(top: 10),
                      child: Column(
                        crossAxisAlignment: CrossAxisAlignment.start,
                        children: [
                          SizedBox(height: 10),
                          Text(
                            "R\$ $_cardValue",
                            style: TextStyle(fontSize: 24),
                          ),
                        ],
                      ),
                    ),
                  ],
                ),
              ),
            ),
          ),
          Container(
            alignment: Alignment.center,
            padding: EdgeInsets.all(8),
            child: Card(
              color: _cor,
              elevation: 5,
              shape: RoundedRectangleBorder(
                borderRadius: BorderRadius.circular(10),
              ),
              child: SizedBox(
                width: 400,
                height: 100,
                child: Column(
                  children: [
                    Container(
                      padding: EdgeInsets.only(top: 10),
                      child: Text(
                        "Venda",
                        style: TextStyle(fontSize: 18, fontWeight: FontWeight.bold),
                      ),
                    ),
                    Container(
                      padding: EdgeInsets.only(top: 10),
                      child: Column(
                        crossAxisAlignment: CrossAxisAlignment.start,
                        children: [
                          SizedBox(height: 10),
                          Text(
                            "R\$ $_cardValue",
                            style: TextStyle(fontSize: 24,),
                          ),
                        ],
                      ),
                    ),
                  ],
                ),
              ),
            ),
          ),
          Container(
            alignment: Alignment.center,
            padding: EdgeInsets.all(8),
            child: Card(
              color: Colors.green.shade600,
              elevation: 5,
              shape: RoundedRectangleBorder(
                borderRadius: BorderRadius.circular(10),
              ),
              child: SizedBox(
                width: 400,
                height: 100,
                child: Column(
                  children: [
                    Container(
                      padding: EdgeInsets.only(top: 10),
                      child: Text(
                        "Faturamento",
                        style: TextStyle(fontSize: 18, fontWeight: FontWeight.bold),
                      ),
                    ),
                    Container(
                      padding: EdgeInsets.only(top: 10),
                      child: Column(
                        crossAxisAlignment: CrossAxisAlignment.start,
                        children: [
                          SizedBox(height: 10),
                          Text(
                            "R\$ $_cardValue",
                            style: TextStyle(fontSize: 24),
                          ),
                        ],
                      ),
                    ),
                  ],
                ),
              ),
            ),
          ),
        ],
      ),
    );
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      drawer: Drawer(
        child: Column(
          children: [
            UserAccountsDrawerHeader(
              currentAccountPicture:
                  ClipOval(child: Image.asset('assets/images/tecnobar.jpg')),
              accountName: Text("Tecnobar"),
              accountEmail: Text("tecnobar@g.unicamp.br"),
            ),
            ListTile(
              leading: Icon(Icons.home),
              title: Text('Home'),
              onTap: () {
                Navigator.of(context).pushNamed('/home');
              },
            ),
            ListTile(
              leading: Icon(Icons.dashboard),
              title: Text('Dashboard'),
              onTap: () {
                Navigator.of(context).pushNamed('/dash');
              },
            ),
            ListTile(
              leading: Icon(Icons.history_sharp),
              title: Text('Historico'),
              onTap: () {
                Navigator.of(context).pushNamed('/history');
              },
            ),
            ListTile(
              leading: Icon(Icons.login),
              title: Text('Sair'),
              onTap: () {
                Navigator.of(context).pushNamedAndRemoveUntil('/login', (route) => false);
              },
            ),
          ],
        ),
      ),
      appBar: AppBar(
        title: Text('Home'),
        centerTitle: true,
      ),
      body: _body(),
    );
  }
}
