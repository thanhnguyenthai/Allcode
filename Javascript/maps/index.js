// maps = object that holds key-value pairs of any data type

const store = new Map([
    ["t-shirt",20],
    ["Jean",30],
    ["socks",10],
    ["underwear",50]
]);
/*
let shoppingcart = 0;
shoppingcart += store.get("t-shirt");
shoppingcart += store.get("underwear");
console.log(shoppingcart);
*/


//sore.get("t-shirt");
store.set("hat", 40);
store.delete("hat");
console.log(store.has("t-shirt"));
console.log(store.size);



store.forEach((value,key) => console.log(`${key} ${value}`));

