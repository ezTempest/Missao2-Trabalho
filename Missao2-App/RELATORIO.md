//Erro 1
int x = "10";
//Compilador: Cannot implicitly convert type 'string' to 'int'
//não pode converter string para int.

//Erro 2
bool b = 1;
//Cannot implicitly convert type 'int' to 'bool'
//Booleano só aceita True ou False

//Erro 3
char c = "A";
//Cannot implicitly convert type 'string' to 'char'
//Char com aspas duplas, o correto é simples

Usei VS Code.
O IntelliSense ajudou com sugestões.
Os erros apareceram sublinhados antes de rodar.
Consegui rodar pelo terminal com dotnet run.