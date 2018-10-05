import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class p01_hogswatch {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        int n = Integer.parseInt(reader.readLine());
        int initialPresents = Integer.parseInt(reader.readLine());
        int presents = initialPresents;
        int visitedHomes = 0;
        int totalTimesWentBack = 0;
        int totalPresentsTaken = 0;

        while (n-- > 0) {
            int presentsToDrop = Integer.parseInt(reader.readLine());
            visitedHomes++;

            if (presentsToDrop <= presents) {
                presents -= presentsToDrop;
            } else {
                int additionalPresents = presentsToDrop - presents;
                int presentsToGet = (initialPresents / visitedHomes) * n + additionalPresents;
                presents = presentsToGet - additionalPresents;
                totalTimesWentBack++;
                totalPresentsTaken += presentsToGet;
            }
        }

        if (totalTimesWentBack == 0) {
            System.out.println(presents);
        } else {
            System.out.println(totalTimesWentBack);
            System.out.println(totalPresentsTaken);
        }
    }
}
