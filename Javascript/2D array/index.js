// an array of array = 2D

let num=["1","2","3"];
let vega=["rau","cu","qua"];
let meat=["egg","beef","chicken"];


let total=[num,vega,meat];

total[2][4] = "mangoes";
for(let list of total) {
    for (let food of list ){
        console.log(food);
    }
}