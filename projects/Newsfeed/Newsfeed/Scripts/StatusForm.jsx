var StatusForm = React.createClass({
    submit: function (e) {
        console.log('triggered form submission...');
        e.preventDefault();
        console.log('prevented default...');
        var text = React.findDOMNode(this.refs.text).value.trim();
        var showLocation = React.findDOMNode(this.refs.showLocation).checked;
        var feeling = React.findDOMNode(this.refs.feeling).value;
        console.log('text: ' + text);
        console.log('showLocation: ' + showLocation);
        console.log('feeling: ' + feeling);
    },
    render: function() {
        return (
            <form className="post-status" onSubmit={this.submit}>
                <textarea ref="text" maxLength="140" placeholder="Enter text here..."></textarea>
                <input ref="showLocation" type="checkbox" />
                Show location?
                &nbsp;&nbsp;&nbsp;&nbsp;
                Feeling&nbsp;
                <select name="feeling" ref="feeling">
                    <option value=""></option>
                    <option value="excited">excited</option>
                    <option value="happy">happy</option>
                    <option value="relaxed">relaxed</option>
                    <option value="retarded">retarded</option>
                </select>
                <br />
                <button type="submit">Post</button>
            </form>
        );
    }
});