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
