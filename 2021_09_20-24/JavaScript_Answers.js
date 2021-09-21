function getHashTags(str){
	output= str.replace(/\W /g, '').toLowerCase().split(' ');

	output.sort(function(a, b){
		  return b.length - a.length;
	});
	var out=[]
	for(i= 0; (i < 3) && (i < output.length); i++){
		out.push('#' + output[i]);
	}
	return out;

}
console.log(getHashTags("How the Avocado Became the Fruit of the Global Trade"));
console.log(getHashTags("Why You Will Probably Pay More for Your Christmas Tree This Year"));
console.log(getHashTags("Hey Parents, Surprise, Fruit Juice Is Not Fruit"));
console.log(getHashTags("Visualizing Science"));