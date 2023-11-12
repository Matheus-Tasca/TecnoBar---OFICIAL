class Venda {
  final int codVenda;
  final DateTime dataRegistro;

  Venda({
    required this.codVenda,
    required this.dataRegistro,
  });

  factory Venda.fromJson(Map<String, dynamic> json) {
    return Venda(
      codVenda: json['codVenda'],
      dataRegistro: DateTime.parse(json['dataRegistro']),
    );
  }
}