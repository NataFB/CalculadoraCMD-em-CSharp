# 🧮 Calculadora em C# (Console)

Projeto de uma **calculadora em C# para console**, desenvolvido com foco em **validação de entrada do usuário** e **organização do código em classes separadas**.

Este projeto foi criado como parte do aprendizado da linguagem C#.
---
## 🎯 Objetivo do Projeto

Criar uma calculadora funcional em modo console que:

- Execute operações matemáticas básicas
- Valide corretamente todas as entradas do usuário
- Evite erros comuns (como divisão por zero)
- Utilize uma estrutura organizada e reutilizável
---
## ⚙️ Funcionalidades

- Calculos básicos, podendo por mais de dois números em alguns casos.
- Menu interativo no console
- Retorno seguro de resultados
- Encerramento controlado da aplicação
---
## 🧠 Conceitos Utilizados

Durante o desenvolvimento do projeto, foram aplicados os seguintes conceitos:

### ✔ Estruturas de Controle
- `if / else`
- `switch`
- `while`
- `for`
- Operador ternário

### ✔ Estruturas de Dados
- `List<double>` para armazenar valores dinamicamente
- Percurso de listas com `for` e `foreach`

### ✔ Métodos e Classes
- Separação das operações em classes específicas
- Métodos estáticos para facilitar o uso no menu

### ✔ Validação de Dados
- Verificação de entrada vazia ou nula com `string.IsNullOrWhiteSpace`
- Conversão segura de números com `double.TryParse`
- Validação de exceções como: Divisão por 0, verificar se a base é negativa em raizes, verificar na potência se ambos os números são 0.
- **Essas validações garantem que o programa não quebre e sempre informe corretamente o usuário quando algo estiver errado.**
### ✔ Cultura Invariante
- Uso de `CultureInfo.InvariantCulture` para garantir:
  - Separador decimal com ponto (`.`)
  - Funcionamento consistente independentemente da configuração regional do sistema

---
