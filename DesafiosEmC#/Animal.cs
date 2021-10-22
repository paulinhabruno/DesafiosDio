//DESAFIO EM FASE DE CONCLUSÃO
//DESAFIO EM FASE DE CONCLUSÃO
//DESAFIO EM FASE DE CONCLUSÃO
//DESAFIO EM FASE DE CONCLUSÃO


//Neste problema, você deverá ler 3 palavras que definem o tipo de animal possível segundo o esquema abaixo, da esquerda para a direita.  Em seguida conclua qual dos animais seguintes foi escolhido, através das três palavras fornecidas.

//Entrada
//A entrada contém 3 palavras, uma em cada linha, necessárias para identificar o animal segundo a figura acima, com todas as letras minúsculas.

//Saída
//Imprima o nome do animal correspondente à entrada fornecida.

using System;
using System.Text;

class MainClass {
  public static void Main (string[] args) {
        string palavra1 = Console.ReadLine();
        string palavra2 = Console.ReadLine();
        string palavra3 = Console.ReadLine();

    if (( palavra1 == "vertebrado") && ( palavra2 == "ave") && ( palavra3 == "onivoro")) {
      Console.WriteLine("pomba\n");    
      
    }
      
      if (( palavra1 == "vertebrado") && ( palavra2 == "ave") && ( palavra3 == "carnivoro")) {
      Console.WriteLine("aguia\n");    
        
      }
      
      if (( palavra1 == "vertebrado") && ( palavra2 == "mamifero") && ( palavra3 == "onivoro")) {
      Console.WriteLine("homem\n");    
        
      }
      
      if (( palavra1 == "vertebrado") && ( palavra2 == "mamifero") && ( palavra3 == "herbivoro")) {
      Console.WriteLine("vaca\n");    
        
      }
      
      if (( palavra1 == "invertebrado") && ( palavra2 == "inseto") && ( palavra3 == "hematofago")) {
      Console.WriteLine("pulga\n");    
      
      }
      
      if (( palavra1 == "invertebrado") && ( palavra2 == "inseto") && ( palavra3 == "herbivoro")) {
      Console.WriteLine("lagarta\n");    
      
      }
      if (( palavra1 == "invertebrado") && ( palavra2 == "anelideo") && ( palavra3 == "hematofago")) {
      Console.WriteLine("sanguessuga\n");    
      
      }
      if (( palavra1 == "invertebrado") && ( palavra2 == "anelideo") && ( palavra3 == "onivoro")) {
      Console.WriteLine("minhoca\n");    
      
      }

     
    
  }
}