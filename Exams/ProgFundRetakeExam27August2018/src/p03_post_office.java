import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;
import java.util.stream.Collectors;

public class p03_post_office {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String text = reader.readLine();
        String[] parts = text.split("[|]");
        String[] partThreeWords = parts[2].split(" ");

        Pattern firstPartPattern = Pattern.compile("([#$%*&])([A-Z]+)\\1");
        Pattern secondPartPattern = Pattern.compile("([\\d]{2}):([\\d]{2})");

        String capitals = "";
        List<String> charsAndLengths = new ArrayList<>();
        Matcher firstPartMatcher = firstPartPattern.matcher(parts[0]);
        if (firstPartMatcher.find()) {
            capitals = firstPartMatcher.group(2);
        }

        Matcher secondPartMatcher = secondPartPattern.matcher(parts[1]);
        while (secondPartMatcher.find()) {
            charsAndLengths.add(secondPartMatcher.group(0));
        }
        charsAndLengths = charsAndLengths.stream().distinct().collect(Collectors.toList());
        List<Character> capitalChars = capitals.chars().mapToObj(e->(char)e).collect(Collectors.toList());
        for (Character capital : capitalChars) {
            for (String charsAndLength : charsAndLengths) {
                String[] tokens = charsAndLength.split("[:]");

                char ch = (char) Integer.parseInt(tokens[0]);
                if (capital.equals(ch)) {
                    List<String> wordsWithChar = Arrays.stream(partThreeWords).filter(x -> x.startsWith(ch + "")).collect(Collectors.toList());
                    int length = Integer.parseInt(tokens[1]);
                    for (String word : wordsWithChar) {
                        if (word.length() == length + 1 && word.startsWith(ch + "")) {
                            System.out.println(word);
                        }
                    }
                }
            }
        }
    }
}
