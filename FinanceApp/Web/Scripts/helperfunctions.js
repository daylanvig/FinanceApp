export const $ = (selector, parent) => {
    return (parent ? parent : document).querySelector(selector);
};
export const $$ = (selector, parent) => {
    return Array.prototype.slice.call((parent ? parent : document).querySelectorAll(selector));
};