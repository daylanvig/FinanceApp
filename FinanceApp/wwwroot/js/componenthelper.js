import { $, $$ } from './helperfunctions';
export default class ComponentHelper {
  constructor(formID) {
    this._form = $(`#${formID}`);
  }

  setupEvents() {
    const elements = $$('component', this._form); //this._setupOnClickEvents(elements.filter(e => e.data.));
  }

  _setupOnClickEvents() {}

}