const nameUtil = require('../src/name-util');
const defaultdict = require('defaultdict2');


test('Canary Test', () => expect(true).toBeTruthy());

var lots_of_names = ["Abdon", "Brandon", "Christopher", "Daniel", "Denys", "Diego", "Edrienne", "Eugene", "Ezequiel",
    "Gustavo", "Houtan", "Jeffry", "Lina", "Luis", "Martin", "Matthew", "Mike", "Naresh", "Nicolas",
    "Patricio", "Pio", "Rachel", "Ravali", "Samad", "Shaneej", "Shara", "Sikender", "Tommy", "Venkat",
    "Victor", "Zachary"];
var expected_result = {A:1, B:1, C:1, D:3, E:3, G:1, H:1, J:1, L:2, M:3, N:2, P:2, R:2, S:4, T:1, V:2, Z:1};

test("Average letter Imperative for empty list",
  () => expect(nameUtil.averageLettersImperative([])).toBe(0));

test("Average letter Imperative for list with one name",
  () => expect(nameUtil.averageLettersImperative(["Venkat"])).toBe(6));

test("Average letter Imperative for a list with names of same lengths",
  () => expect(nameUtil.averageLettersImperative(["James","Jimmy"])).toBe(5));

test("Average letter Imperative for a list with names of different lengths",
  () => expect(nameUtil.averageLettersImperative(["notVenkat", "Venkat"])).toBe(7.5));

test("Average letter Imperative for a list with a lot of names",
  () => expect(nameUtil.averageLettersImperative(lots_of_names)).toBeCloseTo(6.13, 2));

test("Average letter Functional for empty list",
  () => expect(nameUtil.averageLettersFunctional([])).toBe(0));

test("Average letter Functional for list with one name",
  () => expect(nameUtil.averageLettersFunctional(["Venkat"])).toBe(6));

test("Average letter Functional for a list with names of same lengths",
  () => expect(nameUtil.averageLettersFunctional(["James","Jimmy"])).toBe(5));

test("Average letter Functional for a list with names of different lengths",
  () => expect(nameUtil.averageLettersFunctional(["notVenkat", "Venkat"])).toBe(7.5));

test("Average letter Functional for a list with a lot of names",
  () => expect(nameUtil.averageLettersFunctional(lots_of_names)).toBeCloseTo(6.13, 2))

test("Letter Counts Imperative for empty list",
  () => expect(nameUtil.startLetterCountImperative([])).toEqual(defaultdict(0, {})));

test("Letter Counts Imperative for list with one name",
  () => expect(nameUtil.startLetterCountImperative(["Venkat"])).toEqual(defaultdict(0, { V: 1 })));

test("Letter Counts Imperative for list of names with same first letter",
  () => expect(nameUtil.startLetterCountImperative(["Jimmy","James"])).toEqual(defaultdict(0, { J: 2 })));

test("Letter Counts Imperative for list of names with different first letters",
  () => expect(nameUtil.startLetterCountImperative(["NotVenkat","Venkat"])).toEqual(defaultdict(0, { N: 1, V: 1 })));

test("Letter Counts Imperative for list of name with only 1 letter",
  () => expect(nameUtil.startLetterCountImperative(["A"])).toEqual(defaultdict(0, { A: 1 })));

test("Letter Counts Imperative for list with lot of names",
   () => expect(nameUtil.startLetterCountImperative(lots_of_names)).toEqual(defaultdict(0, Object.assign({}, expected_result))));

test("Letter Counts Functional for empty list",
   () => expect(nameUtil.startLetterCountFunctional([])).toEqual({}));

test("Letter Counts Functional for list with one name",
  () => expect(nameUtil.startLetterCountFunctional(["Venkat"])).toEqual({ V: 1 }));

test("Letter Counts Functional for list of names with same first letter",
  () => expect(nameUtil.startLetterCountFunctional(["Jimmy","James"])).toEqual({ J: 2 }));

test("Letter Counts Functional for list of names with different first letters",
  () => expect(nameUtil.startLetterCountFunctional(["NotVenkat","Venkat"])).toEqual({ N: 1, V: 1 }));

test("Letter Counts Functional for list of name with only 1 letter",
  () => expect(nameUtil.startLetterCountFunctional(["A"])).toEqual({ A: 1 }));

test("Letter Counts Functional for list with lots of names",
  () => expect(nameUtil.startLetterCountFunctional(lots_of_names)).toEqual(expected_result));
