# Creational Design Patterns
## Abstract Factory

### Кратко описание
* Цел
 - Предоставя интерфейс за създаване на групи от свързани или зависими обекти, без да определя техните конкретни класове.
 - Създава се супер-фабрика, която създава други фабрики за конкретни продукти.
 
* Приложимост
 - Клиентският софтуер създава конкретна имплементация на абстрактния интерфейс и после използва този интерфейс за създаване на конкретни обекти.
 - Клиентът не знае какъв точно продукт ще получи от всяка конкретна 'фабрика', тъй като използва само абстрактния интерфейс за техните продукти.
 - Този шаблон разделя детайлите по създаване на обекта от неговата употреба.
 - Използва се при системи, които често се променят, тъй като високото ниво на абстракция и разделение позволява нови видове обекти да се добавят без да е необходима промяна на кода, който използва базовия клас.
 - ![](https://sourcemaking.com/files/v2/content/patterns/Abstract_Factory_example1-2x.png)
 
### Структура 

* Примерна структура може да има следните класове:
 - _Client_: Този клас използва интерфейси, декларирани от класовете AbstractFactory и AbstractProduct.
 - _AbstractFactory  _: Това е абстрактана основа на всички конкретни класове. Включва методи за всички типове обекти, които ще се създават.
 - _ConcreteFactory_: Този клас наследява AbstractFactory. ConcreteFactory override-ва методи от AbstractFactory, които ще създават нов свързан обект.
 - _AbstractProduct_: Този клас е основа на всички типове обекти, които фабриката може да създаде.
 - _ConcreteProduct_: Това е конкретна имплементация на класа AbstractProduct. Може да има множество класове, които произлизат от AbstractProduct със специфични функционалности
 
* UML диаграма

  - ![](https://upload.wikimedia.org/wikipedia/commons/9/9d/Abstract_factory_UML.svg)


### Реализация
    
    

    
        /*IVSR:Abstract factory pattern*/
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    namespace DesignPatterns.AbstractFactory
    {
	    public class GenericFactory<T> 
	        where T : new()
	    {
	        public T CreateObject()
	        {
	            return new T();
	        }
	    }
	
	    public abstract class CarFactory
	    {
	        public abstract SportsCar CreateSportsCar();
	        public abstract FamilyCar CreateFamilyCar();
	    }
	    
	    public abstract class FamilyCar
	    {
	        public abstract void Speed(SportsCar abstractSportsCar);
	    }
	
	    public abstract class SportsCar
	    {
	    }
	
	    public class MercedesFactory : CarFactory
	    {
	        public override SportsCar CreateSportsCar()
	        {
	            return new MercedesSportsCar();
	        }
	
	        public override FamilyCar CreateFamilyCar()
	        {
	            return new MercedesFamilyCar();
	        }
	    }
	    
	
	     
	    class MercedesSportsCar : SportsCar
	    {
	    }
	
	    class MercedesFamilyCar : FamilyCar
	    {
	        public override void Speed(SportsCar abstractSportsCar)
	        {
	            Console.WriteLine(GetType().Name + " is slower than "
	                + abstractSportsCar.GetType().Name);
	        }
	    }
	
	    public class Driver
	    {
	        private CarFactory _carFactory;
	        private SportsCar _sportsCar;
	        private FamilyCar _familyCar;
	
	        public Driver(CarFactory carFactory)
	        {
	            _carFactory = carFactory;
	            _sportsCar = _carFactory.CreateSportsCar();
	            _familyCar = _carFactory.CreateFamilyCar();
	        }
	
	        public CarFactory CarFactory
	        {
	            get { return _carFactory; }
	            set { _carFactory = value; }
	        }
	
	        public SportsCar SportsCar
	        {
	            get { return _sportsCar; }
	        }
	
	        public FamilyCar FamilyCar
	        {
	            get { return _familyCar; }
	        }
	
	        public void CompareSpeed()
	        {
	            FamilyCar.Speed(SportsCar);
	        }
	    }
    }