# Creational Design Patterns
## 1. Singleton

### Кратко описание
* Цел
 - Целта му е да подсигури, че даден клас им само една инстанция, и да предостави единствен глобален достъп до нея
 
* Приложимост
 - Използва се, когато в приложението има необходимост от данни, които да се достъпват глобално или когато трябва да има само един клас или точно определен брой инстанции

### Структура 

* Singleton добавя функционалност, като променя съществуващ клас. Необходими модификации:
 - Конструктурът се прави **private** и **static**
 - Добавя се **private static read-only** обект, който се инициализира с private конструктор
 - Добавя се **public static property**, с което да се достъпва private обекта
* UML диаграма

  - ![](https://i-msdn.sec.s-msft.com/dynimg/IC400943.png)


### Реализация
    
    


    static class Program
    {
	    static void Main()
	    {
		    var singleton1 = Singleton.GetSingleton();
		    var singleton2 = Singleton.GetSingleton();
		    
		    Console.WriteLine(singleton1==singleton2);
	    
	    }
    }
    
    public sealed class Singleton
    {
	    private static volatile Singleton _instance;
	    private static readonly object _lockThis = new object();
	    
	    private Singleton() { }
	    
	    public static Singleton GetSingleton()
		    {
			    if (_instance == null)
			    {
				    lock (_lockThis)
				    {
				    	if (_instance == null) _instance = new Singleton();
				    }
			    }
			    return _instance;
		    }
    }


