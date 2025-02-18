# GSLC Task Session 5 And 6
Nathanael Gilberth Tjandra - 2702223286

> Code dapat di download [di sini](https://github.com/KudaT3rbang/Notetaking/tree/main/2024%20Even%20Semester/Code%20Reengineering/Session%205%20%26%206/GSLC%20Task)

## Switch Statement Smell
Kode pada section ini diambil dari [repo ini](https://github.com/mhargrove/GGJ15/blob/master/ServerSide/Item.java). Dalam code **item.java** terdapat Bad Code Smell yaitu Switch Statement Smell, dimana terdapat penggunaan switch statement yang berlebihan untuk menangani sebuah logika untuk tiap item. Switch digunakan di dalam method `apply` untuk memodifikasi objek `Stats` sesuai dengan jenis item.

`Item.java`
```java
// Code ini diambil dari repository github
// https://github.com/mhargrove/GGJ15/tree/c1f2551c2d198b50bbac00d3764de872e467ea3d
// Permasalahan disini adalah Bad Code Smell : Switch Statement
public class Item{
	public ItemTypes type;
	public int posX;
	public int posY;
	public Item(ItemTypes name, int x, int y){
		this.type = name;
		this.posX = x;
		this.posY = y;
	}

	public String toString(){
		return type.netName+"@"+"["+posX+","+posY+"]";
	}

	public Stats apply(Stats in){
		Stats result = in;
		switch(type){
			case BED: 
				result.sleepy = 0;
				result.timeDelta += 30;
				break;
			case FLOWER: 
				result.romance += 15;
				result.cash -= 10;
				break;
			case MEDKIT: 
				result.health += 40;
				result.cash -= 25;
				break;
			case NYQUIL: 
				result.health -= 15;
				result.cash -= 5;
				result.sleepy -= 60;
				result.timeDelta += 15;
				break;
			case ADDERAL: 
				result.sleepy += 50;
				result.cash -= 30;
				result.health -= 10;
				result.moveFastFor = 10;
				break;
			case FOOD: 
				result.health += 20;
				result.cash -= 10;
				result.hungry += 80;
				break; 
			case COIN: 
				result.cash += 25;
				break;
			case BOOKS: 
				if(result.hungry > 50){
					if(result.hungry > 75){
						result.study += 15;
					}
					else{
						result.study += 10;
					}
				}
				result.study += 7;
				if(result.sleepy > 50){
					if(result.sleepy > 75){
						result.study -= 6;
					}
					else{
						result.study -= 2;
					}
				}
				break;
		}
		return result;
	}
}
```
Untuk mengatasi permasalahan ini kita bisa menerapkan *polymorphism* daripada menggunakan switch. Kita bisa membuat setiap item sebagai kelas terpisah.

`Item.java`
```java
// Code ini diambil dari repository github
// https://github.com/mhargrove/GGJ15/tree/c1f2551c2d198b50bbac00d3764de872e467ea3d
// Permasalahan disini adalah Bad Code Smell : Switch Statement
public abstract class Item{
	public ItemTypes type;
	public int posX;
	public int posY;
	public Item(ItemTypes name, int x, int y){
		this.type = name;
		this.posX = x;
		this.posY = y;
	}

	public String toString(){
		return type.netName+"@"+"["+posX+","+posY+"]";
	}

	public abstract Stats apply(Stats in);
}

// Replace conditional menggunakan polymorphism
public class Flower extends Item {
    public Flower(int x, int y) {
        super(ItemTypes.FLOWER, x, y);
    }

    @Override
    public Stats apply(Stats in) {
        in.romance += 15;
        in.cash -= 10;
        return in;
    }
}

public class Medkit extends Item {
    public Medkit(int x, int y) {
        super(ItemTypes.MEDKIT, x, y);
    }

    @Override
    public Stats apply(Stats in) {
        in.health += 40;
        in.cash -= 25;
        return in;
    }
}

public class Nyquil extends Item {
    public Nyquil(int x, int y) {
        super(ItemTypes.NYQUIL, x, y);
    }

    @Override
    public Stats apply(Stats in) {
        in.health -= 15;
        in.cash -= 5;
        in.sleepy -= 60;
        in.timeDelta += 15;
        return in;
    }
}

public class Adderal extends Item {
    public Adderal(int x, int y) {
        super(ItemTypes.ADDERAL, x, y);
    }

    @Override
    public Stats apply(Stats in) {
        in.sleepy += 50;
        in.cash -= 30;
        in.health -= 10;
        in.moveFastFor = 10;
        return in;
    }
}

public class Food extends Item {
    public Food(int x, int y) {
        super(ItemTypes.FOOD, x, y);
    }

    @Override
    public Stats apply(Stats in) {
        in.health += 20;
        in.cash -= 10;
        in.hungry += 80;
        return in;
    }
}

public class Coin extends Item {
    public Coin(int x, int y) {
        super(ItemTypes.COIN, x, y);
    }

    @Override
    public Stats apply(Stats in) {
        in.cash += 25;
        return in;
    }
}

public class Books extends Item {
    public Books(int x, int y) {
        super(ItemTypes.BOOKS, x, y);
    }

    @Override
    public Stats apply(Stats in) {
        if (in.hungry > 50) {
            if (in.hungry > 75) {
                in.study += 15;
            } else {
                in.study += 10;
            }
        }
        in.study += 7;
        if (in.sleepy > 50) {
            if (in.sleepy > 75) {
                in.study -= 6;
            } else {
                in.study -= 2;
            }
        }
        return in;
    }
}
```

## Alternative Classes With Different Interface Smell
Dalam code **HugExample.java** terdapat bad smell, karena terdapat method yang identik yaitu `giveAliceHug()` dan `giveBobHug()`, kedua metode ini hanya berbeda nama tapi memiliki fungsi yang sama. 

`HugExample.java`
```java
class Alice {
    public void giveAliceHug() {
        System.out.println("Alice gives a warm hug!");
    }
}

class Bob {
    public void giveBobHug() {
        System.out.println("Bob gives a warm hug!");
    }
}

public class HugExample {
    public static void main(String[] args) {
        Alice alice = new Alice();
        Bob bob = new Bob();

        alice.giveAliceHug();
        bob.giveBobHug();
    }
}
```
Kita dapat mengatasi masalah ini dengan menggunakan interface `Huggable` yang dapat di implement oleh kedua class.

`HugExample.java`
```java
interface Huggable {
    void giveHug();
}

class Person implements Huggable {
    private String name;

    public Person(String name) {
        this.name = name;
    }

    @Override
    public void giveHug() {
        System.out.println(name + " gives a warm hug!");
    }
}

public class HugExample {
    public static void main(String[] args) {
        Person person1 = new Person("Alice");
        Person person2 = new Person("Bob");

        person1.giveHug();
        person2.giveHug();
    }
}
```