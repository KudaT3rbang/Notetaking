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