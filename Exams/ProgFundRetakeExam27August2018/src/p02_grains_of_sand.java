import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.*;
import java.util.stream.Collectors;

public class p02_grains_of_sand {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        List<Long> numbers = Arrays.stream(reader.readLine().split(" "))
                .map(Long::parseLong).collect(Collectors.toCollection(ArrayList::new));

        String input;
        while (!"Mort".equals(input = reader.readLine())) {
            String[] tokens = input.split(" ");
            String command = tokens[0];
            long value = Long.parseLong(tokens[1]);

            switch (command) {
                case "Add":
                    numbers.add(value);
                    break;
                case "Remove":
                    if (!valueExists(value, numbers)) {
                        if (value < numbers.size()) {
                            int index = (int) value;
                            numbers.remove(index);
                        }
                    } else {
                        for (int i = 0; i < numbers.size(); i++) {
                            if (numbers.get(i) == value) {
                                numbers.remove(i);
                                break;
                            }
                        }
                    }
                    break;
                case "Replace":
                    long replacement = Long.parseLong(tokens[2]);
                    if (valueExists(value, numbers)) {
                        for (int i = 0; i < numbers.size(); i++) {
                            if (numbers.get(i) == value) {
                                numbers.set(i, replacement);
                                break;
                            }
                        }
                    }
                    break;
                case "Increase":
                    Long element = null;

                    for (Long number : numbers) {
                        if (number >= value) {
                            element = number;
                            break;
                        }
                    }

                    if (element == null) {
                        element = numbers.get(numbers.size() - 1);
                    }

                    for (int i = 0; i < numbers.size(); i++) {
                        numbers.set(i, numbers.get(i) + element);
                    }
                    break;
                case "Collapse":
                    numbers.removeIf(num -> value > num);
                    break;
            }
        }
        System.out.println(numbers.toString().replaceAll("[]\\[,]", ""));
    }

    private static boolean valueExists(long value, List<Long> numbers) {
        for (Long number : numbers) {
            if (number == value) {
                return true;
            }
        }
        return false;
    }
}
