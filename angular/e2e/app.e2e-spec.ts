import { NoteAppTemplatePage } from './app.po';

describe('NoteApp App', function() {
  let page: NoteAppTemplatePage;

  beforeEach(() => {
    page = new NoteAppTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
