function additivePersistance(x){
	let i= 0;
	if(x<0){
		x= -x;
	}
	while (x >= 10){
		i++;
		let x2= 0;
		while( x > 0){
			x2+= x%10;
			x= (x-x%10)/10;
		}
		x= x2;
	}
	return i;
}
console.log(additivePersistance(123456));
//123456->21->3
console.log(additivePersistance(9));
//9
console.log(additivePersistance(199));
//199->19->10->1

function multiplicativePersistance(x){
	let i= 0;
	if(x<0){
		x= -x;
	}
	while (x >= 10){
		i++;
		let x2= 1;
		while( x > 0){
			x2*= x%10;
			x= (x-x%10)/10;
		}
		x= x2;
	}
	return i;
}
console.log(multiplicativePersistance(123456));
//123456->720->0
console.log(multiplicativePersistance(9));
//9
console.log(multiplicativePersistance(299));
//299->162->12->2