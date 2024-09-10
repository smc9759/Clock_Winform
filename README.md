# Clock Display

## Language
1. C#
2. Winform




## Function
1. Uses 3 Different Time Information Source to Update Current Time (yyyy-mm-dd hh:mm:ss)
2. DST Time 
3. UTC Time 
4. Win32_CurrentTime class

## Difference DST <-> UTC
### Common Disadvantages
the internal clock of a PC may run slightly faster or slower than the real time.   
This drift can accumulate.  

### DST
1. Pros : Fit in Single PC , with no Communication
2. Cons : Summertime ( 1hour Deviation occurs two times a year )  
for example, U.S. summertime is at March and November )  

### Win32_CurrentTime class

Not recommended.   
(you have to get hour, minute, second each items individually)    
The Win32_CurrentTime abstract is a singleton WMI class (ref. MSDN)    

### CIM APIs
CIM refers to Computer Integrated Manufacturing.  


## Controls

1. Label Clock;
2. Button StartTime;
3. Button EndTime;



## Button
1. Function - saves Time when Clicked
