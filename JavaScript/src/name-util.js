const defaultdict = require('defaultdict2');
const under = require('underscore');

function averageLettersImperative(names)
{
	let total = 0;
	for(const name of names)
	{
    	total += name.length;
	}
	return total / names.length || 0;
}

function averageLettersFunctional(names)
{                       
	return names.map(name => name.length)
	  		.reduce((total, length) => total + length, 0)
	    	/ names.length || 0;
}

function startLetterCountImperative(names)
{
	let letterCounts = defaultdict(0);
	
	for(const name of names)
	{
		letterCounts[name[0]]++;
	}
	
	return letterCounts;
}

function startLetterCountFunctional(names)
{                                                                  
	return under.countBy(names, (name) => name[0]);  
}
	
module.exports = {averageLettersImperative, averageLettersFunctional, startLetterCountImperative, startLetterCountFunctional};
