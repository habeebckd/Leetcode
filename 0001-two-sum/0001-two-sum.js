/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
var twoSum = function(num, target) {
    let arr=[];
  for(i=0;i<num.length-1;i++){
    for(j=i+1;j<num.length;j++){
        if(num[i]+num[j]==target)
        arr.push(i,j)
        
    }
  } 
  return arr
};