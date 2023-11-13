import 'package:flutter/material.dart';
import 'dart:math';

class HistoryPage extends StatefulWidget {
  const HistoryPage({Key? key}) : super(key: key);

  @override
  State<HistoryPage> createState() => HistoryPageState();
}

class HistoryPageState extends State<HistoryPage> {
  String selectedDuration = '10';
  List<Map<String, dynamic>> vendas = [];

  final List<String> descricoes = [
    "Refrigerante",
    "Salgado",
    "Bebida Alcoólica",
    "Porção",
  ];

  @override
  void initState() {
    super.initState();
    gerarDadosSimulados(); 
  }

  void gerarDadosSimulados() {

    vendas = List.generate(
      100,
      (index) {
        final descricao = descricoes[index % descricoes.length];
        final quantidade = Random().nextInt(10) + 1; 
        final valorUnitario = Random().nextDouble() * 10;
        final valorTotal = quantidade * valorUnitario;

        return {
          'id': index + 1,
          'title': descricao,
          'quantidade': quantidade,
          'valorUnitario': valorUnitario.toStringAsFixed(2),
          'valorTotal': valorTotal.toStringAsFixed(2),
        };
      },
    );

    setState(() {});
  }

  Widget _body() {
    return ListView(
      padding: EdgeInsets.symmetric(vertical: 0, horizontal: 8),
      children: [
        Column(
          children: [
            Container(
              padding: EdgeInsets.all(16),
              child: Column(
                children: [
                  Row(
                    mainAxisAlignment: MainAxisAlignment.center,
                    children: [
                      Text('Últimas compras:',
                      style: TextStyle(fontSize: 18),
                      ),
                      SizedBox(width: 10),
                      DropdownButton<String>(
                        items: [
                          '10',
                          '20',
                          '30',
                          '50',
                          '100',
                        ].map((String value) {
                          return DropdownMenuItem<String>(
                            value: value,
                            child: Text(value),
                          );
                        }).toList(),
                        onChanged: (String? value) {
                          setState(() {
                            selectedDuration = value ?? '10';
                          });
                        },
                        value: selectedDuration,
                      ),
                    ],
                  ),
                  SingleChildScrollView(
                    scrollDirection: Axis.horizontal,
                    child: DataTable(
                      dataRowHeight: 50,
                      columns: [
                        DataColumn(label: Text('Descrição')),
                        DataColumn(label: Text('Quantidade')),
                        DataColumn(label: Text('Valor Unitário')),
                        DataColumn(label: Text('Valor Total')),
                      ],
                      rows: vendas
                          .take(int.parse(selectedDuration))
                          .map((venda) {
                        return DataRow(
                          cells: [
                            DataCell(Container(
                              width: 100,
                              child: Text(venda['title']),
                            )),
                            DataCell(Text(venda['quantidade'].toString())),
                            DataCell(Text('\$${venda['valorUnitario']}')),
                            DataCell(Text('\$${venda['valorTotal']}')),
                          ],
                        );
                      }).toList(),
                    ),
                  ),
                ],
              ),
            ),
          ],
        ),
      ],
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
        title: Text('Histórico de Vendas'),
      ),
      body: _body(),
    );
  }
}
