//Arrays Used :
var temp_arr = [1,2,3,4,5,6]
var add_arr = [7,8,]
var t_array=[1,1,2,1,4,5];


console.log("temp_arr : "+ temp_arr);
console.log("add_arr :"+ add_arr);
console.log("t_array :"+ t_array);

//functions used :
function func(item){
	console.log(item+1);
}

function func1(element,index,array){ 
	return element< 10; 
}

function func2(element,index,array){
 return element<6; 
}

function func3(element,index,array){
 return ++element;
}

function func6(result,value){ 
	return (result+value)/2; 
}

function func7(element){
	return element>5;
}

//Comments are the outputs of the array methods :
console.log("concatenation() method : ");
console.log(temp_arr.concat(add_arr));
//[ 1, 2, 3, 4,5, 6, 7, 8]
console.log("forEach() method : ");
temp_arr.forEach(func);
// 2
// 3
// 4
// 5
// 6
// 7
console.log("every() method : "+ temp_arr.every(func1));
// true
console.log("filter() method : "+temp_arr.filter(func2));
// [ 1, 2, 3, 4, 5 ]
console.log("indexOf() method :"+temp_arr.indexOf(3));
// 2
console.log("join() method : "+temp_arr.join());
// '1,2,3,4,5,6'
console.log("lastIndexOf() method :"+t_array.lastIndexOf(1));
// 3
console.log("map() method :"+temp_arr.map(func3));
// [ 2, 3, 4, 5, 6, 7 ]
var popped = temp_arr.pop();
console.log("popped item : "+popped);
// 6
temp_arr.push(8);
console.log("push() method result :"+temp_arr);
// [ 1, 2, 3, 4, 5, 8 ]
console.log("reverse() method :"+temp_arr.reverse());
// [ 8, 5, 4, 3, 2, 1 ]
temp_arr.shift(0);
console.log("shift() method : "+temp_arr);
// [ 5, 4, 3, 2, 1 ]
console.log("toString() method :"+temp_arr.toString());
// '5,4,3,2,1'
temp_arr.unshift(6);
console.log("unshift() method :"+temp_arr);
// [ 6, 5, 4, 3, 2, 1 ]
console.log("splice() method : "+temp_arr.splice(1,3));
// [ 5, 4, 3 ]
var total = temp_arr.reduce(func6);
console.log("reduce() method : "+total);
// 2.5
total = temp_arr.reduceRight(func6);
console.log("reduceRight() method : "+total);
// 3.75
console.log("sort() method : "+temp_arr.sort());
// [ 1, 2, 6 ]
temp_arr.push(3);
temp_arr.push(4);
temp_arr.push(5);

console.log("temp_arr : "+ temp_arr);
// [ 1, 2, 6, 3, 4, 5 ]
console.log("slice() method : "+temp_arr.slice(1,6));
// [ 2, 6, 3, 4, 5 ]
console.log("some() method : "+ temp_arr.some(func7));
// true