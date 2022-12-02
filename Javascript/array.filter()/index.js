// array.filter() = creates a new array with all elements
// that pass the test provided by function

let ages = [18,16,21,17,19,90];

let adult = ages.filter(checages);

adult.forEach(print);
function checages(elements) {
    return elements >=18;
}

function print(element) {
    console.log(element);
};
