const isQuestion = (input: string): boolean => {
  return input[input.length - 1] === '?';
};

const isShouting = (input: string): boolean => {
  return input === input.toUpperCase() && /[A-Z]/.test(input);
};

export const hey = (message: string): string => {
  message = message.trim();
  if (message === '') {
    return 'Fine. Be that way!';
  } else if (isShouting(message) && !isQuestion(message)) {
    return 'Whoa, chill out!';
  } else if (isShouting(message) && isQuestion(message)) {
    return "Calm down, I know what I'm doing!";
  } else if (isQuestion(message)) {
    return 'Sure.';
  } else {
    return 'Whatever.';
  }
};
