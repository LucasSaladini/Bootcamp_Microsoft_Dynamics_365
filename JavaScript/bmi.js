const heightInMeters = 1.75
const weightInKg = 140

const bmi = weightInKg / Math.pow(heightInMeters, 2)

console.log(bmi)

if (bmi < 18.5) {
    console.log('Abaixo do peso')
} else if (bmi >=18.5 && bmi < 25) {
    console.log('Peso normal')
} else if (bmi >= 25 && bmi < 30) {
    console.log('Acima do peso')
} else if (bmi >= 30 && bmi < 40) {
    console.log('Obeso')
} else {
    console.log('Obesidade grave')
}