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
