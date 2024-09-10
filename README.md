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
Over time, the internal clock of a PC can experience drift, where the clock may run slightly faster or slower than the real time. This drift can accumulate and cause differences in displayed time if the clock is not periodically corrected.

### DST
1. Pros : Fit in Single PC , with no Communication
2. Cons : 

## Win32_CurrentTime class

The Win32_CurrentTime abstract is a singleton WMI class (ref. MSDN)
not recommended. (you have to get hour, minute, second each items individually)
## Controls

1. Label Clock;
2. Button StartTime;
3. Button EndTime;

## Button
1. Function - saves Time when Clicked
