package ReceiverProcess;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Stream;


public class Receiver {

  
  public static List<List<Float>> readSensorReadings(){
    List<Float> firstSensorReadings = new ArrayList<>();
    List<Float> secondSensorReadings = new ArrayList<>();
    List<List<Float>> allReadings=new ArrayList<>();
    Scanner scannerObj = new Scanner(System.in); // Create a Scanner object  
    scannerObj.nextLine();
    for(int i=0;i<50;i++){ 
      float num = scannerObj.nextFloat(); // Read user input
      firstSensorReadings.add(num);
    }
    scannerObj.nextLine();
    scannerObj.nextLine();
    for(int j=0;j<50;j++){ 
      float num = scannerObj.nextFloat(); // Read user input
      secondSensorReadings.add(num);
    }
    allReadings.add(firstSensorReadings);
    allReadings.add(secondSensorReadings);
    scannerObj.close();
    return allReadings;
  }
 

 
  public static void calculateStatistics(List<Float> inputReadings, String sensorName) {
    System.out.println(String.format("Statistics for the %s sensor readings are as follows :",sensorName));
    System.out.println("Minimum: " + Stream.of(inputReadings.toArray(new Float[inputReadings.size()]))
    .mapToDouble(Float::valueOf)
    .min().getAsDouble());
System.out.println("Maximum: " + Stream.of(inputReadings.toArray(new Float[inputReadings.size()]))
    .mapToDouble(Float::valueOf)
    .max().getAsDouble());
System.out.println("Average: " + Stream.of(inputReadings.toArray(new Float[inputReadings.size()]))
    .mapToDouble(Float::valueOf)
    .sum() / inputReadings.size());
    
  }
  
 
  public static void main(String[] args) {

  List<List<Float>> sensorReadings=readSensorReadings();

  calculateStatistics(sensorReadings.get(0),"Temperature");
  
  calculateStatistics(sensorReadings.get(1),"SOC");
  
 
  }
  
}
