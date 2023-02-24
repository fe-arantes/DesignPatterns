## Factory Method Design Pattern – Definição e Exemplos Simplificados

O padrão de design Factory Method é um padrão criacional, isto é, ele fornece uma interface para criar objetos em uma superclasse, mas permite que as subclasses alterem o tipo de objetos que serão feitos. Esse padrão permite que uma classe adie a instanciação para suas subclasses.

Isso pode ser útil em situações em que uma classe não pode antecipar o tipo de objeto que ele precisa criar.O padrão Factory Method permite uma abordagem flexível para a criação de objetos e é particularmente útil em situações em que uma classe precisa ser desacoplada das classes que precisa criar.


<sub>Benefícios</sub>

**Abstração da criação de objetos**

Existe uma separação clara do processo de criação de objetos do restante do aplicação.

**Aumenta a Flexibilidade**

Existe uma maior flexibilidade na criação de objetos, pois permite a criação de diferentes tipos sem a necessidade de instanciação explícita.

**Fácil manutenção**

O padrão Factory Method facilita a manutenção de uma aplicação, pois as alterações no processo de criação do objeto podem ser feitas em um local centralizado.


<sub>Quando usar</sub>

Quando uma classe não pode antecipar o tipo de objetos que precisa criar.

Quando uma classe deseja delegar a responsabilidade pela criação do objeto para suas subclasses.

Quando você deseja fornecer uma classe com uma interface simples para criar objetos, mas deseja permitir que as subclasses alterem o tipo de objetos que serão criados.

