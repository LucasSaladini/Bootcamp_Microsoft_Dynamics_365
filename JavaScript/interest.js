/*
    1 - Débito
    2 - Dinheiro ou Pix
    3 - Em duas vezes
    4 - Mais de duas vezes
*/

function applyDiscount(value, discount) {
    return (value - (value * (discount / 100)))
}

function applyInterest(value, interest) {
    return (value + (value * (interest / 100)))
}

const price = 100
const paymentType = 4



if (paymentType === 1) {
    console.log(applyDiscount(price, 10))
} else if (paymentType === 2) {
    console.log(applyDiscount(price, 15))
} else if (paymentType === 3) {
    console.log(price)
} else {
    console.log(applyInterest(price, 10))
}

