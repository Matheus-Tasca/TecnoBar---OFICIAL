import 'package:flutter/material.dart';
import 'dart:convert';
import 'dart:math';
import 'package:http/http.dart' as http;

class HistoryPage extends StatefulWidget {
  const HistoryPage({Key? key}) : super(key: key);

  @override
  State<HistoryPage> createState() => HistoryPageState();
}

class HistoryPageState extends State<HistoryPage> {
  String selectedDuration = '10'; // Valor padrão
  List<Map<String, dynamic>> vendas = []; // Lista para armazenar os dados simulados

  // Descrições sequenciais
  final List<String> descricoes = [
    "Refrigerante",
    "Salgado",
    "Bebida Alcoólica",
    "Porção",
  ];

  @override
  void initState() {
    super.initState();
    gerarDadosSimulados(); // Chame a função para gerar dados simulados ao iniciar a tela
  }

  void gerarDadosSimulados() {
    // Gere dados simulados com base nas descrições
    vendas = List.generate(
      100, // Total de vendas simuladas
      (index) {
        final descricao = descricoes[index % descricoes.length];
        final quantidade = Random().nextInt(10) + 1; // Números aleatórios de 1 a 10
        final valorUnitario = Random().nextDouble() * 10; // Preços aleatórios de 0 a 10
        final valorTotal = quantidade * valorUnitario;

        return {
          'id': index + 1,
          'title': descricao,
          'quantidade': quantidade,
          'valorUnitario': valorUnitario.toStringAsFixed(2), // Arredonda para 2 casas decimais
          'valorTotal': valorTotal.toStringAsFixed(2), // Arredonda para 2 casas decimais
        };
      },
    );

    // Atualize a tela após gerar dados simulados
    setState(() {});
  }

  Widget _body() {
    return ListView(
      padding: EdgeInsets.symmetric(vertical: 0, horizontal: 8),
      children: [
        Column(
          children: [
            Text(
              'Histórico de vendas',
              style: TextStyle(fontSize: 24),
            ),
            Container(
              padding: EdgeInsets.all(16),
              child: Column(
                children: [
                  Row(
                    mainAxisAlignment: MainAxisAlignment.center,
                    children: [
                      Text('Mostrar últimas:'),
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
                      Text(' compras'),
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
                              width: 100, // Largura fixa para a coluna de descrição
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
                  ClipOval(child: Image.asset('assets/images/sonic.jpeg')),
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
              // subtitle: Text('Exercício 3'),
              onTap: () {
                Navigator.of(context).pushNamed('/history');
              },
            ),
            ListTile(
              leading: Icon(Icons.login),
              title: Text('Sair'),
              onTap: () {
                Navigator.of(context).pushNamed('/login');
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
