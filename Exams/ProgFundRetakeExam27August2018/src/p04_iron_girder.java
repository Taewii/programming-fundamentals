import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Comparator;
import java.util.LinkedHashMap;
import java.util.Map;

public class p04_iron_girder {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        Map<String, Train> trains = new LinkedHashMap<>();

        String input;
        while (!"Slide rule".equalsIgnoreCase(input = reader.readLine())) {
            String[] tokens = input.split("[:>]");
            String town = tokens[0];
            String timeOrAmbush = tokens[1].substring(0, tokens[1].length() - 1);
            int passengers = Integer.parseInt(tokens[2]);

            if (!"ambush".equals(timeOrAmbush)) {
                int time = Integer.parseInt(timeOrAmbush);

                if (!trains.containsKey(town)) {
                    Train train = new Train(town, time, passengers);
                    trains.put(town, train);
                } else {
                    Train train = trains.get(town);
                    if (train.getTime() > time) {
                        train.setTime(time);
                    } else if (train.getTime() == 0) {
                        train.setTime(time);
                    }

                    train.addPassengers(passengers);
                }
            } else {
                if (trains.containsKey(town)) {
                    Train train = trains.get(town);
                    train.setTime(0);
                    train.setPassengers(train.getPassengers() - passengers);
                }
            }
        }

        trains.values().stream().filter(x-> x.getTime() != 0 && x.getPassengers() > 0)
                .sorted(Comparator.comparingInt(Train::getTime).thenComparing(Train::getName))
                .forEach(t -> System.out.printf("%s -> Time: %d -> Passengers: %s%n", t.getName(), t.getTime(), t.getPassengers()));
    }
}

class Train {
    private String name;
    private int time;
    private int passengers;

    public Train(String name, int time, int passengers) {
        this.name = name;
        this.time = time;
        this.passengers = passengers;
    }

    public String getName() {
        return name;
    }

    public int getTime() {
        return time;
    }

    public void setTime(int time) {
        this.time = time;
    }

    public int getPassengers() {
        return passengers;
    }

    public void addPassengers(int passengers) {
        this.passengers += passengers;
    }

    public void setPassengers(int passengers) {
        this.passengers = passengers;
    }
}
