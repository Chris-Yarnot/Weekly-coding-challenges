function longestNonrepeatingSubstring(str){
  //we want to iterate through the loop one more time than the length of the string
  str+= str+"-";
  //previous index of the char with cooresponding ascii value
  let lastIndex= new Array(128).fill(0);
  //the closest index of a repeated character to the current index
  let minStartIndex= 0;
  //the maximum length string found so far
  let maxLen=0;
  //the start index of the maximum length string found so far
  let maxStart= 0;
  //the end index of the maximum length string found so far
  let maxEnd= 0;
  for (let i= 1; i<str.length; i++) {
    	//ascii value of current character
	let i2= str[i].charCodeAt(0);
	//if the string ended at this char where would it need to start to not have repeating characters
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
console.log(longestNonrepeatingSubstring("Hello World!"));// --> " World!"

console.log(longestNonrepeatingSubstring("abcabcbb"));// --> "abc"

console.log(longestNonrepeatingSubstring("aaaaaa"));// --> "a"

console.log(longestNonrepeatingSubstring("ab-cde"));// --> "ab-cde"

console.log(longestNonrepeatingSubstring("abcda"));// --> "abcd"
