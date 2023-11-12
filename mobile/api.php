<?php

header('Content-Type: application/json');

$servername = "143.106.241.3:3306/cl202026";
$username = "cl202026";
$password = "cl*19072004";
$dbname = "Venda";

// Conectar ao banco de dados
$conn = new mysqli($servername, $username, $password, $dbname);

// Verificar a conexão
if ($conn->connect_error) {
    die(json_encode(["error" => "Conexão falhou: " . $conn->connect_error]));
}

// Obter dados da tabela 'produtos'
$sql = "SELECT nomeProd, qtdProd, valorTotalVenda, dataRegistro FROM Venda";
$result = $conn->query($sql);

// Verificar se há resultados
if ($result === false) {
    die(json_encode(["error" => "Erro na consulta SQL: " . $conn->error]));
}

// Converter os resultados para um array associativo
$rows = [];
while ($row = $result->fetch_assoc()) {
    $rows[] = $row;
}

// Enviar dados como JSON
echo json_encode($rows);

// Fechar conexão
$conn->close();
?>
