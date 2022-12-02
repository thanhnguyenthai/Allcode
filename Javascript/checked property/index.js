document.getElementById("mybutton").onclick = function() {
    
  const mycheckbox = document.getElementById("mycheckbox");
    const visa = document.getElementById("visa");
    const mastercard = document.getElementById("mastercard");
    const paypal = document.getElementById("paypal");
    if(mycheckbox.checked) {
            console.log("You r subscribe");
    }

    else if(visa.checked)
{
    console.log("You chosse visa ");
}
  else if(mastercard.checked)
{
    console.log("You chosse mastercard ");
}
  else if(paypal.checked)
{
    console.log("You chosse paypal ");
}
    else{
console.log("You r not chosse anything");
    }
}