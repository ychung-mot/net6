import React from 'react';

// SVG for loading icon blob.
// Requires _blobLoadingIcon.scss for animations to work.

function BlobLoadingIcon({ width, height }) {
  return (
    <div>
      <svg width={width} height={height} viewBox="0 0 200 250" fill="none" xmlns="http://www.w3.org/2000/svg">
        <title>Blob Loading Icon</title>
        <path
          class="svg__loading-blob"
          fill="#BAE6FF"
          d="M39.4,-68.2C52.5,-60.6,65.7,-53.1,75.6,-41.7C85.6,-30.4,92.2,-15.2,88.3,-2.3C84.3,10.6,69.7,21.2,60,33C50.4,44.8,45.6,57.8,36.5,64.7C27.3,71.6,13.6,72.4,1,70.6C-11.6,68.8,-23.1,64.5,-36.6,60.1C-50.1,55.6,-65.4,51.1,-75.4,41.1C-85.4,31.1,-90.1,15.5,-87.5,1.5C-84.9,-12.5,-74.9,-25,-66.6,-37.9C-58.3,-50.8,-51.5,-64.1,-40.6,-73C-29.8,-82,-14.9,-86.5,-0.9,-85C13.1,-83.4,26.2,-75.8,39.4,-68.2Z"
          transform="translate(100 100)"
        />
        <path
          class="svg__text"
          d="M7.524 9.376C7.428 9.448 7.292 9.528 7.116 9.616C6.948 9.696 6.748 9.772 6.516 9.844C6.284 9.916 6.024 9.976 5.736 10.024C5.456 10.072 5.156 10.096 4.836 10.096C4.156 10.096 3.544 9.98 3 9.748C2.464 9.508 2.008 9.188 1.632 8.788C1.256 8.388 0.968002 7.924 0.768002 7.396C0.568002 6.868 0.468002 6.30799 0.468002 5.71599C0.468002 5.05999 0.584002 4.45599 0.816002 3.90399C1.056 3.35199 1.38 2.87599 1.788 2.47599C2.196 2.07599 2.672 1.76399 3.216 1.53999C3.768 1.31599 4.352 1.20399 4.968 1.20399C5.2 1.20399 5.436 1.21999 5.676 1.25199C5.916 1.28399 6.14 1.32799 6.348 1.38399C6.564 1.43999 6.752 1.50799 6.912 1.58799C7.08 1.65999 7.208 1.73599 7.296 1.81599C7.232 1.91199 7.18 1.99199 7.14 2.05599C7.108 2.11999 7.072 2.18799 7.032 2.25999C6.992 2.32399 6.948 2.39999 6.9 2.48799C6.852 2.57599 6.788 2.69199 6.708 2.83599C6.604 2.76399 6.48 2.70399 6.336 2.65599C6.2 2.60799 6.056 2.56799 5.904 2.53599C5.752 2.50399 5.596 2.47999 5.436 2.46399C5.284 2.44799 5.144 2.43999 5.016 2.43999C4.552 2.43999 4.12 2.52799 3.72 2.70399C3.328 2.87199 2.988 3.10399 2.7 3.39999C2.412 3.68799 2.184 4.024 2.016 4.40799C1.856 4.792 1.776 5.192 1.776 5.608C1.776 6.016 1.852 6.408 2.004 6.784C2.164 7.16 2.38 7.496 2.652 7.792C2.932 8.088 3.264 8.324 3.648 8.5C4.04 8.676 4.468 8.764 4.932 8.764C5.18 8.764 5.42 8.74 5.652 8.692C5.884 8.644 6.092 8.588 6.276 8.524C6.468 8.46 6.624 8.396 6.744 8.332C6.872 8.268 6.948 8.22 6.972 8.18799L7.524 9.376Z"
          fill="black"
          transform="translate(0 185) scale(3.5)"
        />
        <path
          class="svg__text"
          d="M7.89544 7.54C7.89544 7.172 7.96344 6.82799 8.09944 6.50799C8.24344 6.17999 8.43544 5.896 8.67544 5.656C8.91544 5.408 9.19144 5.212 9.50344 5.068C9.82344 4.924 10.1634 4.85199 10.5234 4.85199C10.7634 4.85199 10.9834 4.88399 11.1834 4.94799C11.3834 5.00399 11.5554 5.07599 11.6994 5.16399C11.8434 5.25199 11.9594 5.34399 12.0474 5.43999C12.1354 5.53599 12.1954 5.61999 12.2274 5.69199L12.2754 4.98399H13.2594V10H12.2274V9.364C12.1874 9.428 12.1234 9.504 12.0354 9.592C11.9474 9.68 11.8314 9.764 11.6874 9.844C11.5514 9.916 11.3874 9.98 11.1954 10.036C11.0034 10.092 10.7834 10.12 10.5354 10.12C10.1514 10.12 9.79544 10.052 9.46744 9.916C9.14744 9.772 8.87144 9.584 8.63944 9.352C8.40744 9.112 8.22344 8.836 8.08744 8.524C7.95944 8.212 7.89544 7.884 7.89544 7.54ZM8.92744 7.47999C8.92744 7.71199 8.96744 7.928 9.04744 8.128C9.13544 8.328 9.25144 8.5 9.39544 8.644C9.53944 8.788 9.71144 8.90399 9.91144 8.99199C10.1114 9.07199 10.3314 9.11199 10.5714 9.11199C10.8114 9.11199 11.0314 9.07199 11.2314 8.99199C11.4394 8.90399 11.6154 8.788 11.7594 8.644C11.9114 8.492 12.0274 8.32 12.1074 8.128C12.1874 7.928 12.2274 7.71199 12.2274 7.47999C12.2274 7.24799 12.1874 7.036 12.1074 6.844C12.0274 6.644 11.9114 6.472 11.7594 6.328C11.6154 6.184 11.4394 6.072 11.2314 5.99199C11.0314 5.90399 10.8114 5.85999 10.5714 5.85999C10.3314 5.85999 10.1114 5.90399 9.91144 5.99199C9.71144 6.072 9.53944 6.184 9.39544 6.328C9.25144 6.472 9.13544 6.644 9.04744 6.844C8.96744 7.036 8.92744 7.24799 8.92744 7.47999Z"
          fill="black"
          transform="translate(0 185) scale(3.5)"
        />
        <path
          class="svg__text"
          d="M15.7325 10H14.7125V0.675995H15.7325V10Z"
          fill="black"
          transform="translate(0 185) scale(3.5)"
        />
        <path
          class="svg__text"
          d="M20.5448 8.764C20.6568 8.9 20.7608 9.032 20.8568 9.16C20.9608 9.28 21.0648 9.40799 21.1688 9.54399C20.9448 9.71999 20.6928 9.85999 20.4128 9.96399C20.1328 10.068 19.8288 10.12 19.5008 10.12C19.1328 10.12 18.7848 10.052 18.4568 9.916C18.1368 9.772 17.8568 9.58 17.6168 9.34C17.3768 9.1 17.1848 8.82 17.0408 8.5C16.9048 8.18 16.8368 7.83999 16.8368 7.47999C16.8368 7.11999 16.9048 6.78 17.0408 6.46C17.1848 6.14 17.3768 5.864 17.6168 5.632C17.8568 5.392 18.1368 5.20399 18.4568 5.068C18.7848 4.924 19.1328 4.85199 19.5008 4.85199C19.8368 4.85199 20.1448 4.90399 20.4248 5.00799C20.7128 5.11199 20.9728 5.25199 21.2048 5.42799L20.5448 6.208C20.4088 6.096 20.2528 6.01199 20.0768 5.95599C19.9008 5.89199 19.7088 5.85999 19.5008 5.85999C19.2608 5.85999 19.0408 5.90399 18.8408 5.99199C18.6408 6.072 18.4648 6.184 18.3128 6.328C18.1688 6.472 18.0568 6.644 17.9768 6.844C17.8968 7.036 17.8568 7.24799 17.8568 7.47999C17.8568 7.71199 17.8968 7.928 17.9768 8.128C18.0568 8.32 18.1688 8.492 18.3128 8.644C18.4648 8.788 18.6408 8.90399 18.8408 8.99199C19.0408 9.07199 19.2608 9.11199 19.5008 9.11199C19.7088 9.11199 19.9008 9.084 20.0768 9.028C20.2528 8.964 20.4088 8.876 20.5448 8.764Z"
          fill="black"
          transform="translate(0 185) scale(3.5)"
        />
        <path
          class="svg__text"
          d="M26.845 10.108H25.981L25.861 8.71599C25.677 9.12399 25.417 9.46 25.081 9.724C24.753 9.988 24.333 10.12 23.821 10.12C23.309 10.12 22.901 9.984 22.597 9.712C22.301 9.432 22.145 9.068 22.129 8.62V4.98399H23.149V8.16399C23.165 8.41199 23.253 8.624 23.413 8.8C23.581 8.976 23.837 9.076 24.181 9.1C24.421 9.1 24.641 9.05999 24.841 8.97999C25.041 8.89199 25.213 8.776 25.357 8.632C25.501 8.488 25.613 8.316 25.693 8.116C25.773 7.916 25.813 7.69599 25.813 7.45599V4.98399H26.845V10.108Z"
          fill="black"
          transform="translate(0 185) scale(3.5)"
        />
        <path
          class="svg__text"
          d="M29.3145 10H28.2945V0.675995H29.3145V10Z"
          fill="black"
          transform="translate(0 185) scale(3.5)"
        />
        <path
          class="svg__text"
          d="M30.4189 7.54C30.4189 7.172 30.4869 6.82799 30.6229 6.50799C30.7669 6.17999 30.9589 5.896 31.1989 5.656C31.4389 5.408 31.7149 5.212 32.0269 5.068C32.3469 4.924 32.6869 4.85199 33.0469 4.85199C33.2869 4.85199 33.5069 4.88399 33.7069 4.94799C33.9069 5.00399 34.0789 5.07599 34.2229 5.16399C34.3669 5.25199 34.4829 5.34399 34.5709 5.43999C34.6589 5.53599 34.7189 5.61999 34.7509 5.69199L34.7989 4.98399H35.7829V10H34.7509V9.364C34.7109 9.428 34.6469 9.504 34.5589 9.592C34.4709 9.68 34.3549 9.764 34.2109 9.844C34.0749 9.916 33.9109 9.98 33.7189 10.036C33.5269 10.092 33.3069 10.12 33.0589 10.12C32.6749 10.12 32.3189 10.052 31.9909 9.916C31.6709 9.772 31.3949 9.584 31.1629 9.352C30.9309 9.112 30.7469 8.836 30.6109 8.524C30.4829 8.212 30.4189 7.884 30.4189 7.54ZM31.4509 7.47999C31.4509 7.71199 31.4909 7.928 31.5709 8.128C31.6589 8.328 31.7749 8.5 31.9189 8.644C32.0629 8.788 32.2349 8.90399 32.4349 8.99199C32.6349 9.07199 32.8549 9.11199 33.0949 9.11199C33.3349 9.11199 33.5549 9.07199 33.7549 8.99199C33.9629 8.90399 34.1389 8.788 34.2829 8.644C34.4349 8.492 34.5509 8.32 34.6309 8.128C34.7109 7.928 34.7509 7.71199 34.7509 7.47999C34.7509 7.24799 34.7109 7.036 34.6309 6.844C34.5509 6.644 34.4349 6.472 34.2829 6.328C34.1389 6.184 33.9629 6.072 33.7549 5.99199C33.5549 5.90399 33.3349 5.85999 33.0949 5.85999C32.8549 5.85999 32.6349 5.90399 32.4349 5.99199C32.2349 6.072 32.0629 6.184 31.9189 6.328C31.7749 6.472 31.6589 6.644 31.5709 6.844C31.4909 7.036 31.4509 7.24799 31.4509 7.47999Z"
          fill="black"
          transform="translate(0 185) scale(3.5)"
        />
        <path
          class="svg__text"
          d="M37.6559 2.77599H38.6759V4.99599H40.0199V5.908H38.6759V10H37.6559V5.908H36.7559V4.99599H37.6559V2.77599Z"
          fill="black"
          transform="translate(0 185) scale(3.5)"
        />
        <path
          class="svg__text"
          d="M40.7364 3.064C40.7364 2.87199 40.8044 2.71199 40.9404 2.58399C41.0844 2.45599 41.2364 2.392 41.3964 2.392C41.5564 2.392 41.7044 2.45599 41.8404 2.58399C41.9764 2.71199 42.0444 2.87199 42.0444 3.064C42.0444 3.256 41.9764 3.41599 41.8404 3.54399C41.7044 3.664 41.5564 3.72399 41.3964 3.72399C41.2364 3.72399 41.0844 3.664 40.9404 3.54399C40.8044 3.41599 40.7364 3.256 40.7364 3.064ZM41.8884 10H40.8684V4.98399H41.8884V10Z"
          fill="black"
          transform="translate(0 185) scale(3.5)"
        />
        <path
          class="svg__text"
          d="M43.3294 4.98399H44.2294C44.2454 5.23199 44.2574 5.45999 44.2654 5.66799C44.2814 5.86799 44.2974 6.06799 44.3134 6.26799C44.4974 5.83599 44.7574 5.492 45.0934 5.236C45.4374 4.98 45.8574 4.85199 46.3534 4.85199C46.8574 4.85199 47.2614 4.99199 47.5654 5.27199C47.8694 5.55199 48.0294 5.91199 48.0454 6.35199V10H47.0134V6.81999C46.9974 6.56399 46.9094 6.348 46.7494 6.172C46.5894 5.988 46.3374 5.888 45.9934 5.87199C45.7534 5.87199 45.5334 5.91599 45.3334 6.00399C45.1334 6.08399 44.9614 6.196 44.8174 6.34C44.6734 6.484 44.5574 6.656 44.4694 6.856C44.3894 7.056 44.3494 7.276 44.3494 7.516V10H43.3294V4.98399Z"
          fill="black"
          transform="translate(0 185) scale(3.5)"
        />
        <path
          class="svg__text"
          d="M49.0988 7.50399C49.0988 7.12799 49.1668 6.78 49.3028 6.46C49.4388 6.132 49.6228 5.85199 49.8548 5.62C50.0868 5.38 50.3588 5.192 50.6708 5.05599C50.9828 4.92 51.3148 4.85199 51.6668 4.85199C51.9388 4.85199 52.1788 4.888 52.3868 4.96C52.6028 5.032 52.7828 5.116 52.9268 5.212C53.0708 5.308 53.1828 5.404 53.2628 5.5C53.3508 5.588 53.4068 5.65199 53.4308 5.69199C53.4308 5.57999 53.4388 5.46399 53.4548 5.344C53.4708 5.216 53.4788 5.09599 53.4788 4.98399H54.4628V9.772C54.4628 10.604 54.2188 11.252 53.7308 11.716C53.2428 12.18 52.5828 12.412 51.7508 12.412C51.4628 12.412 51.2028 12.38 50.9708 12.316C50.7468 12.26 50.5388 12.184 50.3468 12.088C50.1628 11.992 49.9908 11.88 49.8308 11.752C49.6788 11.624 49.5268 11.492 49.3748 11.356L50.0348 10.66C50.2828 10.892 50.5348 11.076 50.7908 11.212C51.0548 11.348 51.3668 11.416 51.7268 11.416C52.2628 11.416 52.6788 11.288 52.9748 11.032C53.2708 10.776 53.4228 10.42 53.4308 9.96399V9.616C53.4308 9.552 53.4388 9.48399 53.4548 9.41199C53.4708 9.33199 53.4788 9.272 53.4788 9.232C53.4068 9.328 53.3148 9.43199 53.2028 9.54399C53.0988 9.64799 52.9748 9.744 52.8308 9.832C52.6868 9.912 52.5188 9.98 52.3268 10.036C52.1348 10.092 51.9188 10.12 51.6788 10.12C51.3028 10.12 50.9588 10.052 50.6468 9.916C50.3348 9.78 50.0628 9.596 49.8308 9.364C49.5988 9.124 49.4188 8.848 49.2908 8.536C49.1628 8.216 49.0988 7.87199 49.0988 7.50399ZM50.1308 7.47999C50.1308 7.71199 50.1708 7.928 50.2508 8.128C50.3388 8.328 50.4548 8.5 50.5988 8.644C50.7428 8.788 50.9148 8.90399 51.1148 8.99199C51.3148 9.07199 51.5348 9.11199 51.7748 9.11199C52.0148 9.11199 52.2348 9.07199 52.4348 8.99199C52.6428 8.90399 52.8188 8.788 52.9628 8.644C53.1148 8.492 53.2308 8.32 53.3108 8.128C53.3908 7.928 53.4308 7.71199 53.4308 7.47999C53.4308 7.24799 53.3908 7.036 53.3108 6.844C53.2308 6.644 53.1148 6.472 52.9628 6.328C52.8188 6.184 52.6428 6.072 52.4348 5.99199C52.2348 5.90399 52.0148 5.85999 51.7748 5.85999C51.5348 5.85999 51.3148 5.90399 51.1148 5.99199C50.9148 6.072 50.7428 6.184 50.5988 6.328C50.4548 6.472 50.3388 6.644 50.2508 6.844C50.1708 7.036 50.1308 7.24799 50.1308 7.47999Z"
          fill="black"
          transform="translate(0 185) scale(3.5)"
        />
        <path
          class="svg__text"
          d="M55.8316 9.328C55.8316 9.136 55.8996 8.97599 56.0356 8.84799C56.1796 8.71199 56.3396 8.644 56.5156 8.644C56.6756 8.644 56.8236 8.71199 56.9596 8.84799C57.1036 8.97599 57.1756 9.136 57.1756 9.328C57.1756 9.536 57.1036 9.69999 56.9596 9.81999C56.8236 9.93999 56.6756 10 56.5156 10C56.3396 10 56.1796 9.93999 56.0356 9.81999C55.8996 9.69999 55.8316 9.536 55.8316 9.328Z"
          fill="black"
          transform="translate(0 185) scale(3.5)"
        />
        <path
          class="svg__text"
          d="M58.4683 9.328C58.4683 9.136 58.5363 8.97599 58.6723 8.84799C58.8163 8.71199 58.9763 8.644 59.1523 8.644C59.3123 8.644 59.4603 8.71199 59.5963 8.84799C59.7403 8.97599 59.8123 9.136 59.8123 9.328C59.8123 9.536 59.7403 9.69999 59.5963 9.81999C59.4603 9.93999 59.3123 10 59.1523 10C58.9763 10 58.8163 9.93999 58.6723 9.81999C58.5363 9.69999 58.4683 9.536 58.4683 9.328Z"
          fill="black"
          transform="translate(0 185) scale(3.5)"
        />
        <path
          class="svg__text"
          d="M61.105 9.328C61.105 9.136 61.173 8.97599 61.309 8.84799C61.453 8.71199 61.613 8.644 61.789 8.644C61.949 8.644 62.097 8.71199 62.233 8.84799C62.377 8.97599 62.449 9.136 62.449 9.328C62.449 9.536 62.377 9.69999 62.233 9.81999C62.097 9.93999 61.949 10 61.789 10C61.613 10 61.453 9.93999 61.309 9.81999C61.173 9.69999 61.105 9.536 61.105 9.328Z"
          fill="black"
          transform="translate(0 185) scale(3.5)"
        />
      </svg>
    </div>
  );
}

export default BlobLoadingIcon;
