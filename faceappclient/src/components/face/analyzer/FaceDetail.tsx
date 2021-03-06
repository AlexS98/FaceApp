import React from 'react';
import { FaceModel } from './FaceModel';

interface FaceModelList {
    list: FaceModel[],
    imagePreview: string
}

export class FaceDetail extends React.Component<FaceModelList>  {
    render() {
        return (
            <div style={{ position: "relative" }}>
                {this.props.imagePreview && <img src={this.props.imagePreview} alt="Uploded file" />}
                {this.props.list.map(e =>
                    <div
                        key={e.faceId}
                        style={{
                            backgroundColor: "#11ffee00",
                            left: e.faceRectangle.left,
                            top: e.faceRectangle.top + 15,
                            width: e.faceRectangle.width,
                            height: e.faceRectangle.height,
                            border: "3px solid red",
                            position: "absolute"
                        }}
                        onClick={_ => alert(JSON.stringify(e.faceAttributes))}
                    ></div>)}
            </div>
        )
    }
}
