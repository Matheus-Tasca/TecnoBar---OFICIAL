class Usuario {
  //atributos
  late String _senha;
  late String _nome;

  //construtor
  Usuario({String? senha, String? nome}) {
    this._senha = senha ?? '';
    this._nome = nome ?? '';
  }

  //getters e setters
  get senha => this._senha;


  set senha( value) => this._senha = value;


  get nome => this._nome;


  set nome( value) => this._nome = value;
}