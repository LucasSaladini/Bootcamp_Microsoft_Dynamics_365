/*
    1 - Débito
    2 - Dinheiro ou Pix
    3 - Em duas vezes
    4 - Mais de duas vezes
*/

const price = 100
const paymentType = 12

if (paymentType === 1) {
    const discount = 0.1
    const newPrice = price - (price * discount)
    console.log(newPrice)
} else if (paymentType === 2) {
    const discount = 0.15
    const newPrice = price - (price * discount)
    console.log(newPrice)
} else if (paymentType === 3) {
    console.log(price)
} else {
    const interest = 0.1
    const newPrice = price + (price * interest)
    console.log(newPrice)
}