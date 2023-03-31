const precoCombustivel = 5.79
const kmPorLitro = 14
const distanciaEmKm = 1580

let litrosConsumidos = ((distanciaEmKm / kmPorLitro) * precoCombustivel).toFixed(2)

console.log(litrosConsumidos)