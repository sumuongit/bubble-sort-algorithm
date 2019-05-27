## Table of Contents
* [General Info](#general-info)
* [Technologies](#technologies)
* [Setup](#setup)
* [Contributing](#contributing)
* [License](#license)

## General Info
This application sorts a given set of numbers following the bubble sort algorithm

>**Bubble sort algorithm** starts from the beginning of the list, compare every adjacent pair, swap their position if they are not in the right order. After each iteration, one less element is needed to be compared until there are no more elements left to be compared.

Let us see the first phase of execution of the **Bubble sort algorithm** on the input array to get the maximum number in place. Hence, finally we get the sorted list of the array after completion of the phases as required.

#### `1   5`   3    18    30    22   37   7    11   8    12   2    50   41   15&nbsp;&nbsp;&nbsp;`No Exchange`<br/>
#### 1  `5    3`   18    30    22   37   7    11   8    12   2    50   41   15&nbsp;&nbsp;&nbsp;`Exchange`<br/>
#### 1   3   `5    18`   30    22   37   7    11   8    12   2    50   41   15&nbsp;&nbsp;&nbsp;`No Exchange`<br/>
#### 1   3    5   `18    30`   22   37   7    11   8    12   2    50   41   15&nbsp;&nbsp;&nbsp;`No Exchange`<br/>
#### 1   3    5    18   `30    22`  37   7    11   8    12   2    50   41   15&nbsp;&nbsp;&nbsp;`Exchange`<br/>
#### 1   3    5    18    22   `30   37`  7    11   8    12   2    50   41   15&nbsp;&nbsp;&nbsp;`No Exchange`<br/>
#### 1   3    5    18    22    30  `37   7`   11   8    12   2    50   41   15&nbsp;&nbsp;&nbsp;`Exchange`<br/>
#### 1   3    5    18    22    30   7   `37   11`  8    12   2    50   41   15&nbsp;&nbsp;&nbsp;`Exchange`<br/>
#### 1   3    5    18    22    30   7    11  `37   8`   12   2    50   41   15&nbsp;&nbsp;&nbsp;`Exchange`<br/>
#### 1   3    5    18    22    30   7    11   8   `37   12`  2    50   41   15&nbsp;&nbsp;&nbsp;`Exchange`<br/>
#### 1   3    5    18    22    30   7    11   8    12  `37   2`   50   41   15&nbsp;&nbsp;&nbsp;`Exchange`<br/>
#### 1   3    5    18    22    30   7    11   8    12   2   `37   50`  41   15&nbsp;&nbsp;&nbsp;`No Exchange`<br/>
#### 1   3    5    18    22    30   7    11   8    12   2    37  `50   41`  15&nbsp;&nbsp;&nbsp;`Exchange`<br/>
#### 1   3    5    18    22    30   7    11   8    12   2    37   41  `50   15`&nbsp;&nbsp;&nbsp;`Exchange`<br/>
#### 1   3    5    18    22    30   7    11   8    12   2    37   41   15   50&nbsp;&nbsp;&nbsp;`50 in place after first phase`

## Technologies
This application is created with:
* Visual Studio 2013
* C# 
	
## Setup
To clone and run this repository you will need [Git](https://git-scm.com/) installed on your computer. From your command line:

```
# Clone this repository
$ git clone https://github.com/sumuongit/bubble-sort-algorithm.git
# Go into the repository
$ cd bubble-sort-algorithm
```

## Contributing
* Fork the repository
* Create a topic branch
* Implement your feature or bug fix
* Add, commit, and push your changes
* Submit a pull request

## License
[MIT License](https://github.com/sumuongit/bubble-sort-algorithm/blob/master/LICENSE)
