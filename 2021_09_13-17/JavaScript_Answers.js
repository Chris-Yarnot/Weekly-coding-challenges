console.log("Hello, World!");

function longestNonrepeatingSubstring(str){
  str+= str+"-";
  let lastIndex= new Array(128).fill(0);
  let minStartIndex= 0;
  let maxLen=0;
  let maxStart= 0;
  let maxEnd= 0;
  for (let i= 1; i<str.length; i++) {
    let i2= str[i].charCodeAt(0);
	let startIndexEndHere= lastIndex[i2];
	if(startIndexEndHere < minStartIndex){
		startIndexEndHere= minStartIndex;
	}else{
		minStartIndex= startIndexEndHere;
	}
	lastIndex[i2]= i+1;
	let len= i - startIndexEndHere;
	if(maxLen < len){
		maxLen= len;
		maxStart= startIndexEndHere;
		maxEnd= i;
	}
  }
	return str.substring(maxStart, maxEnd);
}
console.log(longestNonrepeatingSubstring("Hello World!"));

console.log(longestNonrepeatingSubstring("abcabcbb"));// --> "abc"

console.log(longestNonrepeatingSubstring("aaaaaa"));// --> "a"

console.log(longestNonrepeatingSubstring("abcde"));// --> "abcde"

console.log(longestNonrepeatingSubstring("abcda"));// --> "abcd"