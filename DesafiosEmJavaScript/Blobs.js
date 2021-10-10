// complete as variaveis necessarias

var n = parseInt(gets());

while ( n > 0) { //complete o codigo
  var c = parseFloat(gets());
  let dias = 0;  //atribua o valor correto a variavel
  while ( c > 1.0 ) { // complete o while
    // complete o codigo
    c = c*(1/2);
    dias++;
  }
  console.log(dias + ` dias`);
  n--;//complete o código para a saída
}