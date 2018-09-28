namespace name_util_test

open System
open Microsoft.VisualStudio.TestTools.UnitTesting
open name_util

[<TestClass>]
type TestClass () =

    [<TestMethod>]
    member this.CanaryTest() =
        Assert.IsTrue(true)

    [<TestMethod>]
    member this.averageImperative() =
        let expected = 0.0
        let actual = NameFunctions.averageLetterImperative []
        Assert.AreEqual(expected, actual)

    [<TestMethod>]
    member this.averageImperativeForOneName() =
        let expected = 6.0
        let actual = NameFunctions.averageLetterImperative ["Venkat"]
        Assert.AreEqual(expected, actual)

    [<TestMethod>]
    member this.averageImperativeForTwoNamesDifferentSizes() =
        let expected = 7.5
        let actual = NameFunctions.averageLetterImperative ["notVenkat";"Venkat"]
        Assert.AreEqual(expected, actual)

    [<TestMethod>]
    member this.averageImperativeForTwoNamesSameSizes() =
        let expected = 5.0
        let actual = NameFunctions.averageLetterImperative ["James";"Jimmy"]
        Assert.AreEqual(expected, actual)

    [<TestMethod>]
    member this.averageImperativeForLotOfNames() =
        let expected = 6.13
        let actual = NameFunctions.averageLetterImperative ["Abdon"; "Brandon"; "Christopher"; "Daniel"; "Denys"; "Diego"; "Edrienne"; "Eugene"; "Ezequiel";
            "Gustavo"; "Houtan"; "Jeffry"; "Lina"; "Luis"; "Martin"; "Matthew"; "Mike"; "Naresh"; "Nicolas"; "Patricio"; "Pio"; "Rachel"; "Ravali"; "Samad";
            "Shaneej"; "Shara"; "Sikender"; "Tommy"; "Venkat"; "Victor"; "Zachary"]
        Assert.AreEqual(expected, actual, 2.0)

    [<TestMethod>]
    member this.averageFunctionalForEmptyList() =
        let expected = 0.0
        let actual = NameFunctions.averageLetterFunctional []
        Assert.AreEqual(expected, actual)

    [<TestMethod>]
    member this.averageFunctionalForOneName() =
        let expected = 6.0
        let actual = NameFunctions.averageLetterFunctional ["Venkat"]
        Assert.AreEqual(expected, actual)

    [<TestMethod>]
    member this.averageFunctionalForTwoNamesDifferentSizes() =
        let expected = 7.5
        let actual = NameFunctions.averageLetterFunctional ["notVenkat";"Venkat"]
        Assert.AreEqual(expected, actual)

    [<TestMethod>]
    member this.averageFunctionalForTwoNamesSameSizes() =
        let expected = 5.0
        let actual = NameFunctions.averageLetterFunctional ["James";"Jimmy"]
        Assert.AreEqual(expected, actual)

    [<TestMethod>]
    member this.averageFunctionalForLotOfNames() =
        let expected = 6.13
        let actual = NameFunctions.averageLetterFunctional ["Abdon"; "Brandon"; "Christopher"; "Daniel"; "Denys"; "Diego"; "Edrienne"; "Eugene"; "Ezequiel";
            "Gustavo"; "Houtan"; "Jeffry"; "Lina"; "Luis"; "Martin"; "Matthew"; "Mike"; "Naresh"; "Nicolas"; "Patricio"; "Pio"; "Rachel"; "Ravali"; "Samad";
            "Shaneej"; "Shara"; "Sikender"; "Tommy"; "Venkat"; "Victor"; "Zachary"]
        Assert.AreEqual(expected, actual, 2.0)

    [<TestMethod>]
    member this.startingLetterImperativeForEmptyList()=
        let actual = NameFunctions.startLetterCountImperative []
        Assert.AreEqual(0, actual.Count)

    [<TestMethod>]
    member this.startingLetterImperativeForListWithOneName()=
        let expected = dict['V', 1]
        let actual = NameFunctions.startLetterCountImperative ["Venkat"]
        for KeyValue(k, v) in actual do
            Assert.AreEqual(expected.[k],  v)

    [<TestMethod>]
    member this.startingLetterImperativeForOnlyOneLetter()=
        let expected = dict['A', 1]
        let actual = NameFunctions.startLetterCountImperative ["A"]
        for KeyValue(k, v) in actual do
            Assert.AreEqual(expected.[k],  v)

    [<TestMethod>]
    member this.startingLetterImperativeForListWithSameStartLetter()=
        let expected = dict['J', 2]
        let actual = NameFunctions.startLetterCountImperative ["James"; "Jimmy"]
        for KeyValue(k, v) in actual do
            Assert.AreEqual(expected.[k],  v)

    [<TestMethod>]
    member this.startingLetterImperativeForListWithNamesOfDifferentStartLetter()=
        let expected = dict['n', 1; 'V', 1]
        let actual = NameFunctions.startLetterCountImperative ["notVenkat"; "Venkat"]
        for KeyValue(k, v) in actual do
            Assert.AreEqual(expected.[k],  v)

    [<TestMethod>]
    member this.startingLetterImperativeForLongList()=
        let expected = dict['A', 1; 'B', 1; 'C', 1; 'D', 3; 'E', 3; 'G', 1; 'H', 1; 'J', 1; 'L', 2; 'M', 3; 
        'N', 2; 'P', 2; 'R', 2; 'S', 4; 'T', 1; 'V', 2; 'Z', 1]
        let actual = NameFunctions.startLetterCountFunctional ["Abdon"; "Brandon"; "Christopher"; "Daniel"; 
        "Denys"; "Diego"; "Edrienne"; "Eugene"; "Ezequiel"; "Gustavo"; "Houtan"; "Jeffry"; "Lina"; "Luis"; 
        "Martin"; "Matthew"; "Mike"; "Naresh"; "Nicolas"; "Patricio"; "Pio"; "Rachel"; "Ravali"; "Samad"; 
        "Shaneej"; "Shara"; "Sikender"; "Tommy"; "Venkat"; "Victor"; "Zachary"]
        for KeyValue(k, v) in actual do
            Assert.AreEqual(expected.[k],  v)

    [<TestMethod>]
    member this.startingLetterFunctionalForEmptyList()=
        let actual = NameFunctions.startLetterCountFunctional []
        Assert.AreEqual(0, actual.Count)

    [<TestMethod>]
    member this.startingLetterFunctionalForListWithOneName()=
        let expected = dict['V', 1]
        let actual = NameFunctions.startLetterCountFunctional ["Venkat"]
        for KeyValue(k, v) in actual do
            Assert.AreEqual(expected.[k],  v)

    [<TestMethod>]
    member this.startingLetterFunctionalForOnlyOneLetter()=
        let expected = dict['A', 1]
        let actual = NameFunctions.startLetterCountFunctional ["A"]
        for KeyValue(k, v) in actual do
            Assert.AreEqual(expected.[k],  v)

    [<TestMethod>]
    member this.startingLetterFunctionalForListWithNamesOfSameStartingLetter()=
        let expected = dict['J', 2]
        let actual = NameFunctions.startLetterCountFunctional ["James"; "Jimmy"]
        for KeyValue(k, v) in actual do
            Assert.AreEqual(expected.[k],  v)

    [<TestMethod>]
    member this.startingLetterFunctionalForListWithNamesOfDifferentStartingLetters()=
        let expected = dict['n', 1; 'V', 1]
        let actual = NameFunctions.startLetterCountFunctional ["notVenkat"; "Venkat"]
        for KeyValue(k, v) in actual do
            Assert.AreEqual(expected.[k],  v)

    [<TestMethod>]
    member this.startingLetterFunctionalForLongList()=
        let expected = dict['A', 1; 'B', 1; 'C', 1; 'D', 3; 'E', 3; 'G', 1; 'H', 1; 'J', 1; 'L', 2; 'M', 3; 
        'N', 2; 'P', 2; 'R', 2; 'S', 4; 'T', 1; 'V', 2; 'Z', 1]
        let actual = NameFunctions.startLetterCountFunctional ["Abdon"; "Brandon"; "Christopher"; "Daniel"; 
        "Denys"; "Diego"; "Edrienne"; "Eugene"; "Ezequiel"; "Gustavo"; "Houtan"; "Jeffry"; "Lina"; "Luis"; 
        "Martin"; "Matthew"; "Mike"; "Naresh"; "Nicolas"; "Patricio"; "Pio"; "Rachel"; "Ravali"; "Samad"; 
        "Shaneej"; "Shara"; "Sikender"; "Tommy"; "Venkat"; "Victor"; "Zachary"]
        for KeyValue(k, v) in actual do
            Assert.AreEqual(expected.[k],  v)
