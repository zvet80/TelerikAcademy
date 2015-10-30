# Creational Design Patterns
## Builder

### Кратко описание
* Цел
 - Отделя създаването на сложен обект от неговото представяне, така че един и същ процес на създаване да може да се използва за различни представяния
 
* Приложимост
 - Използва се, когато в приложението има сложен обект, който трябва да се създаде, като се използват различни други обекти (части).
 - В такъв случай кодът се запълва с много Part обекти, които да се съберат и да се получи крайния сложен обект.
 - За да се избегне това, се прави един обект - Builder, на който се подават параметри, а той се грижи как да конструира крайния обект.
 - ![](https://sourcemaking.com/files/v2/content/patterns/Builder_example1-2x.png)

### Структура 

* Примерна структура може да има следните класове:
 - _ConcreteBuilder_: конкретните класове, които ще създават сложния Product. Те следят от какви части има необходимост и се използва от клиента, за да получи Product обекта.
 - _Builder_: интерфейс за създаване на реалните продукти.
 - _Director_: Това е клиентския код, който задава необходимите части, които трябва да се съберат, за да се получи крайния продукт.
 - _Product_: Това е обектът, който ще се създаде след събиране на многото части.
 
* UML диаграма

  - ![](http://www.dofactory.com/images/diagrams/net/builder.gif)


### Реализация
    
    

    
    //Represents a product created by the builder

    public class Car
    {
	    public Car()
	    {
	    }
	    
	    public int Wheels { get; set; }
	    
	    public string Colour { get; set; }
    }
    
    //The builder abstraction
    public interface ICarBuilder
    {
	    void SetColour(string colour);
	    
	    void SetWheels(int count);
	    
	    Car GetResult();
    }
    
    //Concrete builder implementation
    public class CarBuilder : ICarBuilder
    {
	    private Car _car;
	    
	    public CarBuilder()
	    {
	    	this._car = new Car();
	    }
	    
	    public void SetColour(string colour)
	    {
	    	this._car.Colour = colour;
	    }
	    
	    public void SetWheels(int count)
	    {
	    	this._car.Wheels = count;
	    }
	    
	    public Car GetResult()
	    {
	    	return this._car;
	    }
    }
    
    //The director
    public class CarBuildDirector
    {
	    public Car Construct()
	    {
		    CarBuilder builder = new CarBuilder();
		    
		    builder.SetColour("Red");
		    builder.SetWheels(4);
		    
		    return builder.GetResult();
	    }
    }