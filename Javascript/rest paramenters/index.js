// rest parameters = represents an indefinite number of parameters ( packs arguments into an array)

let a =1;
let b =2;
let c =3;
let d =4;
let e =5;

console.log(sum(c,d,e));

function sum(x,y,...numbers){  // cos the x , y sẽ bị thay thể cho c vs d nên kết quả là e
    let total = 0;
    for (let number of numbers){
        total += number
    }
    return total;
}